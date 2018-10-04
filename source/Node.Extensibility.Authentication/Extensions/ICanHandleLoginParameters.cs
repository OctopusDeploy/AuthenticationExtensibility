using Octopus.CoreUtilities;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface ICanHandleLoginParameters
    {
        Maybe<LoginInitiatedResult> WasExternalLoginInitiated(string encodedQueryString);
    }
}