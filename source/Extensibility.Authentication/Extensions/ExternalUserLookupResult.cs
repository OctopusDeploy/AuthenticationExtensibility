using System;
using Octopus.Data.Resources.Users;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    public class ExternalUserLookupResult
    {
        public ExternalUserLookupResult(IdentityResource[] identities)
        {
            Identities = identities;
        }

        public IdentityResource[] Identities { get; }
    }
}