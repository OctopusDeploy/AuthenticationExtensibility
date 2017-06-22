using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Octopus.Data.Model;

namespace Octopus.Node.Extensibility.Authentication.Resources
{
    public class AuthenticationProviderElement
    {
        public static string FormsAuthenticateLinkName = "FormsAuthenticate";
        public static string AuthenticateLinkName = "Authenticate";

        public AuthenticationProviderElement()
        {
            Links = new LinkCollection();
        }

        public string Name { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public IdentityType IdentityType { get; set; }

        public bool FormsLoginEnabled { get; set; }

        public LinkCollection Links { get; set; }

        public string[] JavascriptLinks { get; set; }

        public string[] CSSLinks { get; set; }
    }
}