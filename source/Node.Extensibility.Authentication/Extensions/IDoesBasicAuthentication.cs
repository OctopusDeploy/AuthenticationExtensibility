using System.Threading;
using Octopus.Node.Extensibility.Authentication.Storage.User;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface IDoesBasicAuthentication
    {
        /// <summary>
        /// Gets the priority order for checking credentials 
        /// </summary>
        /// <remarks>This is important when multiple providers are enabled, as some will log things more noisily if
        /// the credentials don't match a known user.</remarks>
        int Priority { get; }

        AuthenticationUserCreateResult ValidateCredentials(string username, string password, CancellationToken cancellationToken);
    }
}