﻿using System.Threading;
using Octopus.Server.Extensibility.Authentication.Storage.User;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface IDoesBasicAuthentication
    {
        /// <summary>
        /// Gets the priority order for checking credentials 
        /// </summary>
        /// <remarks>This is important when multiple providers are enabled, as some will log things more noisily if
        /// the credentials don't match a known user.</remarks>
        int Priority { get; }

        AuthenticationUserCreateOrUpdateResult ValidateCredentials(string username, string password, CancellationToken cancellationToken);
    }
}