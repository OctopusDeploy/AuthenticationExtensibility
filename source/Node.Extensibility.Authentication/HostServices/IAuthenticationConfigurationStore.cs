namespace Octopus.Node.Extensibility.Authentication.HostServices
{
    public interface IAuthenticationConfigurationStore
    {
        string[] GetTrustedRedirectUrls();

        bool GetIsAutoLoginEnabled();
    }
}