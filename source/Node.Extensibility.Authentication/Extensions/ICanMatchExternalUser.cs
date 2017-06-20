using Octopus.Data.Model.User;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface ICanMatchExternalUser
    {
        Identity Search(string provider, string username);
    }
}