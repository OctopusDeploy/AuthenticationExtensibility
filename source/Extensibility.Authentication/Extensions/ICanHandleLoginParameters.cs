using Octopus.CoreUtilities;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanHandleLoginParameters
    {
        Maybe<LoginInitiatedResult> WasExternalLoginInitiated(string encodedQueryString);
    }
}