using System.Security.Principal;
using System.Threading;
using Octopus.Node.Extensibility.Authentication.Storage.User;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface ISupportsAutoUserCreationFromPrincipal
    {
        AuthenticationUserCreateResult GetOrCreateUser(IPrincipal principal, CancellationToken cancellationToken);
    }
}