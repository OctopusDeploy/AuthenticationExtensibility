using System.Net;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface IAuthenticationSchemeProvider
    {
        string ChallengePath { get; }
        AuthenticationSchemes AuthenticationScheme { get; }
    }
}