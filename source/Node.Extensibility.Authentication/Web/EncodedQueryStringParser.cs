using System.Linq;
using System.Net;

namespace Octopus.Node.Extensibility.Authentication.Web
{
    public class EncodedQueryStringParser
    {
        public QueryStringParameter[] Parse(string encodedQueryString)
        {
            if (encodedQueryString.StartsWith("?"))
                encodedQueryString = encodedQueryString.Substring(1);

            var pairs = encodedQueryString.Split('&');

            return pairs.Select(p =>
                {
                    var paramAndValue = p.Split('=');
                    return new QueryStringParameter
                    {
                        Name = paramAndValue[0],
                        Value = DecodeValue(paramAndValue[1])
                    };
                }
                ).ToArray();
        }

        string DecodeValue(string encodedValue)
        {
            return WebUtility.UrlDecode(encodedValue);
        }

        public class QueryStringParameter
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
    }
}