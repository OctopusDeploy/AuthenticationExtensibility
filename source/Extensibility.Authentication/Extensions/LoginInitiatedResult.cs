namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public class LoginInitiatedResult
    {
        public LoginInitiatedResult(string providerName)
        {
            ProviderName = providerName;
        }

        public string ProviderName { get; }
    }
}