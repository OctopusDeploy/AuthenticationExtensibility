using System;
using System.Collections.Generic;
using System.Threading;
using Octopus.Data;
using Octopus.Data.Model.User;
using Octopus.Data.Storage.User;
using Octopus.Server.MessageContracts.Features.Users;

namespace Octopus.Server.Extensibility.Authentication.HostServices
{
    public interface IUpdateableUserStore : IUserStore
    {
        IResult<IUser> Create(
            string username,
            string displayName,
            string emailAddress,
            CancellationToken cancellationToken,
            ProviderUserGroups? providerGroups = null,
            IEnumerable<Identity>? identities = null,
            ApiKeyDescriptor? apiKeyDescriptor = null,
            bool isService = false,
            string? password = null);

        void EnableUser(UserId userId);

        void DisableUser(UserId userId);

        IUser AddIdentity(UserId userId, Identity identity, CancellationToken cancellationToken);

        IUser UpdateIdentity(UserId userId, Identity identity, CancellationToken cancellationToken);

        void ClearSecurityGroupIds(string provider, UserId userId);

        void SetSecurityGroupIds(string provider, UserId userId, IEnumerable<string> ids, DateTimeOffset updated);
    }
}