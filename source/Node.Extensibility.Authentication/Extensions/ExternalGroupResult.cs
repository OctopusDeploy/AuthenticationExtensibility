using System.Collections.Generic;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public class ExternalGroupResult
    {
        public ExternalGroupResult(string identityProviderName, IEnumerable<string> groupIds)
        {
            IdentityProviderName = identityProviderName;
            GroupIds = groupIds;
            Succeeded = true;
        }

        public ExternalGroupResult(string identityProviderName, string failureReason)
        {
            IdentityProviderName = identityProviderName;
            FailureReason = failureReason;
        }

        public string IdentityProviderName { get; }

        public bool Succeeded { get; }

        public IEnumerable<string> GroupIds { get; }

        public string FailureReason { get; }
    }
}