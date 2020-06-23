namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanHandleLoginParameters
    {
        /// <returns>Non-null if this provider detects that it's external authentication provider has initiated a login via the query string.</returns>
        LoginInitiatedResult? WasExternalLoginInitiated(string encodedQueryString);
    }
}