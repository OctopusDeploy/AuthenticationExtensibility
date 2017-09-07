using System.Threading;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface ICanLookupExternalUsers
    {
        ExternalUserLookupResult Search(string searchTerm, CancellationToken cancellationToken);
    }
}