using System.Threading;
using Octopus.Data.Model.User;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public interface ICanMatchExternalUser
    {
        /// <summary>
        /// Returns an identity if one can be exactly matched to the given name
        /// </summary>
        /// <returns>The matching identity or null if no match could be found.</returns>
        Identity? Match(string name, CancellationToken cancellationToken);
    }
}