using Octopus.Node.Extensibility.Authentication.Resources;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface IAuthenticationProviderWithGroupSupport : IAuthenticationProvider
    {
        AuthenticationProviderThatSupportsGroups GetGroupLookupElement();
    }
}