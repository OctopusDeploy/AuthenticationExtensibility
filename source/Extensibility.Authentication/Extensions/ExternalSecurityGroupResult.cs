using Octopus.Server.Extensibility.Authentication.HostServices;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public class ExternalSecurityGroupResult
    {
        public ExternalSecurityGroupResult(string providerName, ExternalSecurityGroup[] groups)
        {
            ProviderName = providerName;
            Groups = groups;
        }

        public string ProviderName { get; set; }
        public ExternalSecurityGroup[] Groups { get; set; }
    }
}