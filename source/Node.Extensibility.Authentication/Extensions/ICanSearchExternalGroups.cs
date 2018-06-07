using System.Threading;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface ICanSearchExternalGroups
    {
        ExternalSecurityGroupResult Search(string name, CancellationToken cancellationToken);
    }
}