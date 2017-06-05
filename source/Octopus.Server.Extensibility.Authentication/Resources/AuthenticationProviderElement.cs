using Octopus.Data.Model;

namespace Octopus.Server.Extensibility.Authentication.Resources
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

        public bool IsGuestProvider { get; set; }

        public bool FormsLoginEnabled { get; set; }

        public string LinkHtml { get; set; }

        public LinkCollection Links { get; set; }

        public string[] JavascriptLinks { get; set; }

        public string[] CSSLinks { get; set; }
    }
}