namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanLookupExternalUsers
    {
        ExternalUserLookupResult Search(string searchTerm);
    }
}