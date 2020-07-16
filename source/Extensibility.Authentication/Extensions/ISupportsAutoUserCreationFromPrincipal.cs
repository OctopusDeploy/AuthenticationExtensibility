using System;
using System.Security.Principal;
using System.Threading;
using Octopus.Data.Model.User;
using Octopus.Server.Extensibility.Results;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ISupportsAutoUserCreationFromPrincipal : IIdentityProviderService
    {
        IResultFromExtension<IUser> GetOrCreateUser(IPrincipal principal, CancellationToken cancellationToken);
    }
}