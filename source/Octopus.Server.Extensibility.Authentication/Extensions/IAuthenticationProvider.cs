using Octopus.Server.Extensibility.Authentication.Resources;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface IAuthenticationProvider
    {
        string IdentityProviderName { get; }

        bool IsEnabled { get; }

        bool SupportsPasswordManagement { get; }

        AuthenticationProviderElement GetAuthenticationProviderElement(string requestDirectoryPath);
    }
}