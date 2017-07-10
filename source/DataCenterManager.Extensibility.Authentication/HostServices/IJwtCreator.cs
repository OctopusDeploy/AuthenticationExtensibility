using Octopus.Data.Model.User;

namespace Octopus.DataCenterManager.Extensibility.Authentication.HostServices
{
    public interface IJwtCreator
    {
        string CreateFor(IUser user);
    }
}