using System;
using System.Collections.Generic;
using System.Linq;
using Octopus.Data.Model.User;
using Octopus.Server.Extensibility.Authentication.Resources.Identities;
using Octopus.Server.MessageContracts.Features.Users;

namespace Octopus.Server.Extensibility.Authentication.Model
{
    public static class IdentityExtensionMethods
    {
        public static IdentityResource ToResource(this Identity identity)
        {
            return new IdentityResource(identity.IdentityProviderName)
                .WithClaims(identity.Claims);
        }

        public static Identity WithClaims(this Identity identity, Dictionary<string, IdentityClaimResource> claims)
        {
            foreach (var kvp in claims)
                if (identity.Claims.ContainsKey(kvp.Key))
                    identity.Claims[kvp.Key].Value = kvp.Value.Value;
                else
                    identity.Claims.Add(kvp.Key, new IdentityClaim(kvp.Value.Value, kvp.Value.IsIdentifyingClaim));
            return identity;
        }

        public static Identity WithClaim(this Identity identity, string type, string value, bool isIdentifyingClaim, bool isServerSideOnly = false)
        {
            if (identity.Claims.ContainsKey(type))
            {
                var claim = identity.Claims[type];
                claim.Value = value;
                claim.IsIdentifyingClaim = isIdentifyingClaim;
                claim.IsServerSideOnly = isServerSideOnly;
            }
            else
            {
                var claim = new IdentityClaim(value, isIdentifyingClaim, isServerSideOnly);
                identity.Claims.Add(type, claim);
            }

            return identity;
        }

        public static bool IsEquivalent(this Identity identity, IdentityResource other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (identity.IdentityProviderName != other.IdentityProviderName) return false;
            return identity.Claims.All(kvp =>
            {
                if (!kvp.Value.IsIdentifyingClaim || kvp.Value.IsServerSideOnly)
                    return true;
                if (!other.Claims.ContainsKey(kvp.Key))
                    return false;
                var existingClaimValue = kvp.Value.Value;
                var bothClaimsAreNullOrWhitespace = string.IsNullOrWhiteSpace(existingClaimValue) &&
                    string.IsNullOrWhiteSpace(other.Claims[kvp.Key].Value);
                var existingClaimHasValueAndMatches = !string.IsNullOrWhiteSpace(existingClaimValue) &&
                    existingClaimValue.Equals(other.Claims[kvp.Key].Value,
                        StringComparison.OrdinalIgnoreCase);
                return bothClaimsAreNullOrWhitespace || existingClaimHasValueAndMatches;
            });
        }
    }
}