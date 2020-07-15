using System;
using System.Collections.Generic;
using System.Threading;
using Octopus.Data;
using Octopus.Data.Model.User;
using Octopus.Data.Storage.User;

namespace Octopus.Server.Extensibility.Authentication.HostServices
{
    public interface IUpdateableUserStore : IUserStore
    {
        Result<IUser> Create(
            string username,
            string displayName,
            string emailAddress,
            CancellationToken cancellationToken,
            ProviderUserGroups? providerGroups = null,
            IEnumerable<Identity>? identities = null,
            ApiKeyDescriptor? apiKeyDescriptor = null,
            bool isService = false,
            string? password = null);

        void EnableUser(string userId);

        void DisableUser(string userId);

        IUser AddIdentity(string userId, Identity identity, CancellationToken cancellationToken);

        IUser UpdateIdentity(string userId, Identity identity, CancellationToken cancellationToken);

        void ClearSecurityGroupIds(string provider, string userId);

        void SetSecurityGroupIds(string provider, string userId, IEnumerable<string> ids, DateTimeOffset updated);
    }
}