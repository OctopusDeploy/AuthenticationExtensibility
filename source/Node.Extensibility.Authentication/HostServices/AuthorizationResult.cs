using System;

namespace Octopus.Node.Extensibility.Authentication.HostServices
{
    public class AuthorizationResult
    {
        readonly Lazy<string> helpText;

        public AuthorizationResult(bool isAuthorized, Lazy<string> helpText = null)
        {
            IsAuthorized = isAuthorized;
            this.helpText = helpText ?? new Lazy<string>(() => null);
        }

        public bool IsAuthorized { get; }

        public string HelpText => helpText.Value;
    }
}