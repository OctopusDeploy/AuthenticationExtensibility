using Octopus.Node.Extensibility.Authentication.Resources.Identities;

namespace Octopus.Node.Extensibility.Authentication.Extensions.Identities
{
    public interface IUseAuthenticationIdentities
    {
        IdentityMetadataResource GetMetadata();
    }
}