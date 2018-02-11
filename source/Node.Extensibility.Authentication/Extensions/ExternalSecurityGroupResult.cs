using Octopus.Node.Extensibility.Authentication.HostServices;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public class ExternalSecurityGroupResult
    {
        public string Providerame { get; set; }
        public ExternalSecurityGroup Groups { get; set; }
    }
}