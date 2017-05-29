using Octopus.Node.Extensibility.Authentication.Resources;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface IAuthenticationProvider
    {
        /// <summary>
        /// Descriptive name for the identity provider
        /// </summary>
        string IdentityProviderName { get; }

        /// <summary>
        /// Gets whether the authentication is currently enabled
        /// </summary>
        bool IsEnabled { get; }
        
        /// <summary>
        /// Indicates whether this authentication provider supports password management through the 
        /// Octopus UI.  External providers, for example, typical do not.
        /// </summary>
        bool SupportsPasswordManagement { get; }

        /// <summary>
        /// Gets an AuthenticationProviderElement that describes the authentication providers configuration.
        /// This is typically used by the UI.
        /// </summary>
        AuthenticationProviderElement GetAuthenticationProviderElement();

        /// <summary>
        /// Gets the list of authentication URLs this provider uses.  This is used for things like whitelisting
        /// API access when in MaintenanceMode
        /// </summary>
        string[] GetAuthenticationUrls();
    }
}