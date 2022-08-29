using System;
using System.Net;

namespace Octopus.Server.Extensibility.Authentication.Extensions;

public interface IAuthenticationSchemeProvider : IIdentityProviderService
{
    string ChallengePath { get; }
    AuthenticationSchemes AuthenticationScheme { get; }
}