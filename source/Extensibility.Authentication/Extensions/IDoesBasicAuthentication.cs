using System;
using System.Threading;
using Octopus.Data.Model.User;
using Octopus.Server.Extensibility.Results;

namespace Octopus.Server.Extensibility.Authentication.Extensions;

public interface IDoesBasicAuthentication : IIdentityProviderService
{
    /// <summary>
    /// Gets the priority order for checking credentials
    /// </summary>
    /// <remarks>
    /// This is important when multiple providers are enabled, as some will log things more noisily if
    /// the credentials don't match a known user.
    /// </remarks>
    int Priority { get; }

    IResultFromExtension<IUser> ValidateCredentials(string username, string password, CancellationToken cancellationToken);
}