using System;

namespace Octopus.Server.Extensibility.Authentication.Extensions;

public interface IIdentityProviderService
{
    public string IdentityProviderName { get; }
}