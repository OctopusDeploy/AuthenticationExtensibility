using System.Threading;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanLookupExternalUsers
    {
        ExternalUserLookupResult Search(string searchTerm, CancellationToken cancellationToken);
    }
}