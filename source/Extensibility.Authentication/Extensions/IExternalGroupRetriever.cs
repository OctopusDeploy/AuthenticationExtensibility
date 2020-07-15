using System.Threading;
using Octopus.Data.Model.User;
using Octopus.Server.Extensibility.Results;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface IExternalGroupRetriever : IIdentityProviderService
    {
        /// Returns the list of security group "ids".  For AD these would be sids, for OAuth these may be roles or sids
        ResultFromExtension<ExternalGroupResult> Read(IUser user, CancellationToken cancellationToken);
    }
}