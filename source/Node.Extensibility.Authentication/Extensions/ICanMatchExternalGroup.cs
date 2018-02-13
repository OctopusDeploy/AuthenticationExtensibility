using System.Threading;
using Octopus.Data.Model.User;

namespace Octopus.Node.Extensibility.Authentication.Extensions
{
    public interface ICanMatchExternalGroup
    {
        /// <summary>
        /// Returns an identity if one can be exactly matched to the given name
        /// </summary>
        /// <returns>Returns null if the provider is disabled, otherwise a result with a matching ExternalSecurityGroup if a single match was found. If none or more than 1 were found the group will be null.</returns>
        ExternalSecurityGroupResult Match(string name, CancellationToken cancellationToken);
    }
}