using Octopus.Data.Storage.User;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface IDoesBasicAuthentication
    {
        UserCreateOrUpdateResult ValidateCredentials(string username, string password);
    }
}