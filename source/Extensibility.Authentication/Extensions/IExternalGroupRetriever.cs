using System.Threading;
using Octopus.Data.Model.User;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface IExternalGroupRetriever
    {
        /// Returns the list of security group "ids".  For AD these would be sids, for OAuth these may be roles or sids
        ExternalGroupResult Read(IUser user, CancellationToken cancellationToken);
    }
}