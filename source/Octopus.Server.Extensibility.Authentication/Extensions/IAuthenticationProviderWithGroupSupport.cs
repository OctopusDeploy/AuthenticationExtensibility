using Octopus.Server.Extensibility.Authentication.Resources;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface IAuthenticationProviderWithGroupSupport : IAuthenticationProvider
    {
        AuthenticationProviderThatSupportsGroups GetGroupLookupElement();
    }
}