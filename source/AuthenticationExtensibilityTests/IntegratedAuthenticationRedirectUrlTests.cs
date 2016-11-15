using NSubstitute;
using NUnit.Framework;
using Octopus.Server.Extensibility.Authentication.HostServices;

namespace AuthenticationExtensibilityTests
{
    [TestFixture]
    public class IntegratedAuthenticationRedirectUrlTests
    {
        [TestCase("/folder1/api", null, ExpectedResult = true)]
        [TestCase("~/folder1/api", null, ExpectedResult = true)]
        [TestCase("http://site1/folder1/api", null, ExpectedResult = false)]
        [TestCase("http://localhost:9005", new [] { "http://localhost:9005" }, ExpectedResult = true)]
        [TestCase("https://localhost:9005", new[] { "https://localhost:9005" }, ExpectedResult = true)]
        [TestCase("https://localhost:9005", new[] { "https://localhost:9005" }, ExpectedResult = true)]
        [TestCase("http://localhost:9005", new[] { "http://localhost:9005" }, ExpectedResult = true)]
        [TestCase("folder1/api", null, ExpectedResult = false)]
        [TestCase("http://site2/folder1/api", new[] {""}, ExpectedResult = false)]
        [TestCase("http://localhost:9005", new[] { "https://localhost:9005" }, ExpectedResult = false)]
        public bool IsPathLocalTest(string url, string[] whitelist)
        {
            return Requests.IsLocalUrl(url, whitelist);
        }
    }
}