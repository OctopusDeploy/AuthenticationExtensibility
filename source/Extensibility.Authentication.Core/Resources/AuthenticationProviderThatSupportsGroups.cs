namespace Octopus.Node.Extensibility.Authentication.Resources
{
    public class AuthenticationProviderThatSupportsGroups
    {
        public string Id => Name;

        public string Name { get; set; }

        public bool IsRoleBased { get; set; }

        public bool SupportsGroupLookup { get; set; }
        public string LookupUri { get; set; }
    }
}