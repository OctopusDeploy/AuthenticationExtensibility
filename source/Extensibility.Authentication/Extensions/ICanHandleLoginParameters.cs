using System;

namespace Octopus.Server.Extensibility.Authentication.Extensions;

public interface ICanHandleLoginParameters : IIdentityProviderService
{
    /// <returns>True if this provider detects that it's external authentication provider has initiated a login via the query string. Returns null if this provider is disabled.</returns>
    bool? WasExternalLoginInitiated(string encodedQueryString);
}