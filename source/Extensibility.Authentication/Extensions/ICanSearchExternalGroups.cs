using System.Threading;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanSearchExternalGroups
    {
        /// <returns>Null if the provider is disabled.</returns>
        ExternalSecurityGroupResult? Search(string name, CancellationToken cancellationToken);
    }
}