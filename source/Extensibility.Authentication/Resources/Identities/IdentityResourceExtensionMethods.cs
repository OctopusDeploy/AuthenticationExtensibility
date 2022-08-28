using System;
using System.Collections.Generic;
using System.Linq;
using Octopus.Data.Model.User;
using Octopus.Server.Extensibility.Authentication.Model;
using Octopus.Server.MessageContracts.Features.Users;

namespace Octopus.Server.Extensibility.Authentication.Resources.Identities;

public static class IdentityResourceExtensionMethods
{
    public static Identity ToIdentity(this IdentityResource identity)
    {
        return new Identity(identity.IdentityProviderName)
            .WithClaims(identity.Claims);
    }

    internal static IdentityResource WithClaims(this IdentityResource identity, Dictionary<string, IdentityClaim> claims)
    {
        foreach (var kvp in claims.Where(x => !x.Value.IsServerSideOnly))
            if (identity.Claims.ContainsKey(kvp.Key))
                identity.Claims[kvp.Key] = new IdentityClaimResource(kvp.Value.Value, kvp.Value.IsIdentifyingClaim);
            else
                identity.Claims.Add(kvp.Key, new IdentityClaimResource(kvp.Value.Value, kvp.Value.IsIdentifyingClaim));
        return identity;
    }
}