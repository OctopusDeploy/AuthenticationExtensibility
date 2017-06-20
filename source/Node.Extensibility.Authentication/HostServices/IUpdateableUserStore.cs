using System;
using System.Collections.Generic;
using Octopus.Data.Model.User;
using Octopus.Data.Storage.User;

namespace Octopus.Node.Extensibility.Authentication.HostServices
{
    public interface IUpdateableUserStore : IUserStore
    {
        UserCreateResult Create(
            string username,
            string displayName,
            string emailAddress, 
            IEnumerable<Identity> identities = null,
            ApiKeyDescriptor apiKeyDescriptor = null, 
            string id = null,
            bool isService = false,
            string password = null);

        void EnableUser(string userId);
        void DisableUser(string userId);

        void ClearSecurityGroupIds(string provider);
        void SetSecurityGroupIds(string provider, IEnumerable<string> ids, DateTimeOffset updated);
    }
}