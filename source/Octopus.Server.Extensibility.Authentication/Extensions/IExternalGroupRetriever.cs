using System.Collections.Generic;
using Octopus.Data.Model.User;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface IExternalGroupRetriever
    {
        /// Returns the list of security group "ids".  For AD these would be sids, for OAuth these may be roles or sids
        IEnumerable<ExternalGroupResult> Read(IUser user);
    }

    public class ExternalGroupResult
    {
        public string ProviderName { get; set; }
        public string GroupId { get; set; }
    }
}