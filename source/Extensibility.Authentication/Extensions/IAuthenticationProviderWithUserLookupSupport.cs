using System;
using Octopus.Server.Extensibility.Authentication.Resources;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface IAuthenticationProviderWithUserLookupSupport : IAuthenticationProvider
    {
        /// <returns>Null if the provider is disabled</returns>
        AuthenticationProviderThatSupportsGroups? GetGroupLookupElement();
    }
}