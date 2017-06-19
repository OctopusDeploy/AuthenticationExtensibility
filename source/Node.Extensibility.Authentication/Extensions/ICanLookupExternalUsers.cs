using Octopus.Data.Model.User;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface ICanLookupExternalUsers
    {
        Identity[] Search(string searchTerm);
    }
}