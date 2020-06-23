using System.Security.Principal;
using System.Threading;
using Octopus.Data.Model.User;
using Octopus.Server.Extensibility.Results;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ISupportsAutoUserCreationFromPrincipal
    {
        ResultFromExtension<IUser> GetOrCreateUser(IPrincipal principal, CancellationToken cancellationToken);
    }
}