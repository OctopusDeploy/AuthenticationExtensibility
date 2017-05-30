using System.Net;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface IAuthenticationSchemeProvider
    {
        string ChallengePath { get; }
        AuthenticationSchemes AuthenticationScheme { get; }
    }
}