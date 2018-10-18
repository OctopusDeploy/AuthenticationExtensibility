using System.Threading;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanSearchExternalUsers
    {
        ExternalUserLookupResult Search(string searchTerm, CancellationToken cancellationToken);
    }
}