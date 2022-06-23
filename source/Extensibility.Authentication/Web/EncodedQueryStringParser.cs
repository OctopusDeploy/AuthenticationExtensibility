using System;
using System.Linq;
using System.Net;

namespace Octopus.Server.Extensibility.Authentication.Web;

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
                    return new QueryStringParameter(paramAndValue[0], DecodeValue(paramAndValue[1]));
                }
            )
            .ToArray();
    }

    string DecodeValue(string encodedValue)
    {
        return WebUtility.UrlDecode(encodedValue);
    }

    public class QueryStringParameter
    {
        public QueryStringParameter(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public string Value { get; }
    }
}