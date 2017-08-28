using Octopus.Data.Resources.Users;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public class ExternalUserLookupResult
    {
        public ExternalUserLookupResult(string providerName, IdentityResource[] identities)
        {
            ProviderName = providerName;
            Identities = identities;
        }

        public string ProviderName { get; }
        public IdentityResource[] Identities { get; }
    }
}