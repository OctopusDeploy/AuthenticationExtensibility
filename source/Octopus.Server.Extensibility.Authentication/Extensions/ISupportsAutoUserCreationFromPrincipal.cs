using System.Security.Principal;
using Octopus.Data.Storage.User;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ISupportsAutoUserCreationFromPrincipal
    {
        UserCreateOrUpdateResult GetOrCreateUser(IPrincipal principal);
    }
}