using System.Security.Principal;
using System.Threading;
using Octopus.Server.Extensibility.Authentication.Storage.User;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ISupportsAutoUserCreationFromPrincipal
    {
        AuthenticationUserCreateOrUpdateResult GetOrCreateUser(IPrincipal principal, CancellationToken cancellationToken);
    }
}