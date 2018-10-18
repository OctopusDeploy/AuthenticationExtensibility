using System.Threading;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanSearchExternalGroups
    {
        ExternalSecurityGroupResult Search(string name, CancellationToken cancellationToken);
    }
}