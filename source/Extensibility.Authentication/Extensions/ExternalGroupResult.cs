using System.Collections.Generic;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public class ExternalGroupResult
    {
        public ExternalGroupResult(IEnumerable<string> groupIds)
        {
            GroupIds = groupIds;
        }

        public IEnumerable<string>? GroupIds { get; }
    }
}