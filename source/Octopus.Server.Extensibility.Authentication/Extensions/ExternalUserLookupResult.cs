using Octopus.Data.Model.User;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public class ExternalUserLookupResult
    {
        public ExternalUserLookupResult(string providerName, Identity[] identities)
        {
            ProviderName = providerName;
            Identities = identities;
        }

        public string ProviderName { get; }
        public Identity[] Identities { get; }
    }
}