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
            Identity identity = null,
            ApiKeyDescriptor apiKeyDescriptor = null, 
            string id = null,
            bool isService = false);

        void EnableUser(string userId);
        void DisableUser(string userId);

        IUser AddIdentity(string userId, Identity identity);
        IUser UpdateIdentity(string userId, Identity identity);
    }
}