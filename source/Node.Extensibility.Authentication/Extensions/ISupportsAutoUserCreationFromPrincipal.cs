﻿using System.Security.Principal;
using Octopus.Node.Extensibility.Authentication.Storage.User;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface ISupportsAutoUserCreationFromPrincipal
    {
        AuthenticationUserCreateOrUpdateResult GetOrCreateUser(IPrincipal principal);
    }
}