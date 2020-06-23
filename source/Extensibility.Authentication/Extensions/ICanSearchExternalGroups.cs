using System.Threading;
using Octopus.Server.Extensibility.Results;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanSearchExternalGroups
    {
        public string ProviderName { get; }

        /// <returns>Null if the provider is disabled.</returns>
        ResultFromExtension<ExternalSecurityGroupResult> Search(string name, CancellationToken cancellationToken);
    }
}