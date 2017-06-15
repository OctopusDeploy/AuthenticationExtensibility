using Octopus.Data.Storage.User;

namespace Octopus.Node.Extensibility.Authentication.HostServices
{
    public interface IUpdateableUserStore : IUserStore
    {
        UserCreateOrUpdateResult GetOrCreateUser(
            string username, 
            string displayName, 
            string emailAddress, 
            string externalId,
            ApiKeyDescriptor apiKeyDescriptor = null);

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
    }
}