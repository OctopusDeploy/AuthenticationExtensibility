using Octopus.Node.Extensibility.Authentication.Resources;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface IAuthenticationProviderWithUserLookupSupport : IAuthenticationProvider
    {
        AuthenticationProviderThatSupportsGroups GetGroupLookupElement();
    }
}