using System.Security.Principal;
using Octopus.Server.Extensibility.Authentication.Storage.User;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface ISupportsAutoUserCreationFromPrincipal
    {
        AuthenticationUserCreateOrUpdateResult GetOrCreateUser(IPrincipal principal);
    }
}