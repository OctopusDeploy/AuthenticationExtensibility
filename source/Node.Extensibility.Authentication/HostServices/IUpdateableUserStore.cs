using Octopus.Data.Model.User;
using Octopus.Data.Storage.User;

namespace Octopus.Node.Extensibility.Authentication.HostServices
{
    public interface IUpdateableUserStore : IUserStore
    {
        UserCreateOrUpdateResult Create(
            string username,
            string displayName,
            string emailAddress, 
            ApiKeyDescriptor apiKeyDescriptor = null, 
            string id = null,
            bool isService = false);

        UserCreateOrUpdateResult CreateOrUpdate(
            string username,
            string displayName,
            string emailAddress,
            ApiKeyDescriptor apiKeyDescriptor,
            bool isService);

        void EnableUser(string userId);
        void DisableUser(string userId);

        IUser AddIdentity(string userId, IIdentity identity);
        IUser UpdateIdentity(string userId, IIdentity identity);
    }
}