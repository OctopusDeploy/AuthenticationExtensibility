using System;
using System.Threading;
using Octopus.Server.Extensibility.Results;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanSearchExternalUsers : IIdentityProviderService
    {
        /// <returns>Null if the provider is disabled.</returns>
        ResultFromExtension<ExternalUserLookupResult> Search(string searchTerm, CancellationToken cancellationToken);
    }
}