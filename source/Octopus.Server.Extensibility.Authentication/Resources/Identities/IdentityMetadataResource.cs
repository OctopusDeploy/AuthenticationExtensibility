using Octopus.Data.Model;

namespace Octopus.Server.Extensibility.Authentication.Resources.Identities
{
    public class IdentityMetadataResource
    {
        public string ProviderName { get; set; }

        public ClaimDescriptor[] ClaimDescriptors { get; set; }

        public LinkCollection Links { get; set; }
    }
}