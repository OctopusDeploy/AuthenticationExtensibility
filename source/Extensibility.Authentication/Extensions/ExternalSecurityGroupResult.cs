using Octopus.Server.Extensibility.Authentication.HostServices;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public class ExternalSecurityGroupResult
    {
        public ExternalSecurityGroupResult(string providerame, ExternalSecurityGroup[] groups)
        {
            Providerame = providerame;
            Groups = groups;
        }

        public string Providerame { get; set; }
        public ExternalSecurityGroup[] Groups { get; set; }
    }
}