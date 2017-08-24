using System;
using Octopus.Data.Model.User;
using Octopus.Data.Resources.Users;

namespace Octopus.Server.Extensibility.Authentication.Extensions.Identities
{
    public interface IProvideIdentity
    {
        string IdentityTypeName { get; }

        Type IdentityType { get; }
        bool IdentityTypeIsSupported(Identity identity);
        IdentityResource Map(Identity identity);

        Type IdentityResourceType { get; }
        bool IdentityResourceTypeIsSupported(IdentityResource resource);

        Identity Map(IdentityResource resource);
    }
}