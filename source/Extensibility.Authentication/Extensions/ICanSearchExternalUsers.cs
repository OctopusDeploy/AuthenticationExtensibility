using System.Threading;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanSearchExternalUsers
    {
        /// <returns>Null if the provider is disabled.</returns>
        ExternalUserLookupResult? Search(string searchTerm, CancellationToken cancellationToken);
    }
}