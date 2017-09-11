using Octopus.Data.Model;

namespace Octopus.Node.Extensibility.Authentication.Resources.Identities
{
    public class IdentityMetadataResource
    {
        public string IdentityProviderName { get; set; }

        public ClaimDescriptor[] ClaimDescriptors { get; set; }

        public LinkCollection Links { get; set; }
    }
}