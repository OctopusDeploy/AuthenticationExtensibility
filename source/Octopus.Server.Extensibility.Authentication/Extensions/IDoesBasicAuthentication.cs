using Octopus.Server.Extensibility.Authentication.Storage.User;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface IDoesBasicAuthentication
    {
        AuthenticationUserCreateOrUpdateResult ValidateCredentials(string username, string password);
    }
}