using System;
using Octopus.Data.Model.User;

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

        bool? Matches(Identity identity1, Identity identity2);
        bool? Matches(Identity identity, IdentityResource identityResource);
    }
}