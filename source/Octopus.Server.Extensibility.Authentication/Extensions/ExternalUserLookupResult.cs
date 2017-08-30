using Octopus.Data.Resources.Users;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public class ExternalUserLookupResult
    {
        public ExternalUserLookupResult(string identityProviderName, IdentityResource[] identities)
        {
            IdentityProviderName = identityProviderName;
            Identities = identities;
        }

        public string IdentityProviderName { get; }
        public IdentityResource[] Identities { get; }
    }
}