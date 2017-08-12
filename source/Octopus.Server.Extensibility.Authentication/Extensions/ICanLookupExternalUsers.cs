using Octopus.Data.Model.User;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanLookupExternalUsers
    {
        Identity[] Search(string provider, string searchTerm);
    }
}