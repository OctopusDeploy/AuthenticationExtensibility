using System;
using Octopus.Server.Extensibility.Authentication.HostServices;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public class ExternalSecurityGroupResult
    {
        public ExternalSecurityGroupResult(ExternalSecurityGroup[] groups)
        {
            Groups = groups;
        }

        public ExternalSecurityGroup[] Groups { get; }
    }
}