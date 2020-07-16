using System;
using System.Threading;
using Octopus.Server.Extensibility.Results;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanSearchExternalGroups : IIdentityProviderService
    {
        /// <returns>Null if the provider is disabled.</returns>
        IResultFromExtension<ExternalSecurityGroupResult> Search(string name, CancellationToken cancellationToken);
    }
}