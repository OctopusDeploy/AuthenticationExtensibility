using System.Threading;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface ICanSearchExternalUsers
    {
        ExternalUserLookupResult Search(string searchTerm, CancellationToken cancellationToken);
    }
}