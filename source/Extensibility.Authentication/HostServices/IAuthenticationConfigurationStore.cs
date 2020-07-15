using System;

namespace Octopus.Server.Extensibility.Authentication.HostServices
{
    public interface IAuthenticationConfigurationStore
    {
        string[] GetTrustedRedirectUrls();

        bool GetIsAutoLoginEnabled();
    }
}