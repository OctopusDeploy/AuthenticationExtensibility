using System;
using Octopus.Server.Extensibility.Authentication.Resources.Identities;

namespace Octopus.Server.Extensibility.Authentication.Extensions.Identities
{
    public interface IUseAuthenticationIdentities
    {
        IdentityMetadataResource GetMetadata();
    }
}