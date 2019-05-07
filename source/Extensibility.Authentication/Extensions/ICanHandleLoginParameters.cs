namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanHandleLoginParameters
    {
        bool WasExternalLoginInitiated(string encodedQueryString, out string providerName); 
    }
}