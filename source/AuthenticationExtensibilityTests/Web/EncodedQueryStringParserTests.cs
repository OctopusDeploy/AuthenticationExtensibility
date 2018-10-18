using System.Linq;
using NUnit.Framework;
using Octopus.Server.Extensibility.Authentication.Web;
using Shouldly;

namespace AuthenticationExtensibilityTests.Web
{
    [TestFixture]
    public class EncodedQueryStringParserTests
    {
        [Test]
        public void QuestionMarkIsIgnored()
        {
            var str = "?param=value";

            var parser = new EncodedQueryStringParser();

            var results = parser.Parse(str);

            results.Length.ShouldBe(1);
            results.First().Name.ShouldBe("param");
        }

        [Test]
        public void ValueShouldBeDecoded()
        {
            var str = "?iss=https%3A%2F%2Fdev-123456.oktapreview.com";

            var parser = new EncodedQueryStringParser();

            var results = parser.Parse(str);

            results.First().Value.ShouldBe("https://dev-123456.oktapreview.com");
        }

        [Test]
        public void MultipleParametersAreHandled()
        {
            var str = "?param=value&iss=https%3A%2F%2Fdev-123456.oktapreview.com";

            var parser = new EncodedQueryStringParser();

            var results = parser.Parse(str);

            results.Length.ShouldBe(2);
            results.First().Name.ShouldBe("param");
            results.First().Value.ShouldBe("value");
            results.Last().Name.ShouldBe("iss");
            results.Last().Value.ShouldBe("https://dev-123456.oktapreview.com");
        }
    }
}