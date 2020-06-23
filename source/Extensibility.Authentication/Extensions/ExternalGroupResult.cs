using System.Collections.Generic;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public class ExternalGroupResult
    {
        public ExternalGroupResult(string identityProviderName, IEnumerable<string> groupIds)
        {
            IdentityProviderName = identityProviderName;
            GroupIds = groupIds;
        }

        public string IdentityProviderName { get; }

        public IEnumerable<string>? GroupIds { get; }
    }
}