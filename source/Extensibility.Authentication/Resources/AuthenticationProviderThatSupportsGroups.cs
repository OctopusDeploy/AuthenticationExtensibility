using System;

namespace Octopus.Server.Extensibility.Authentication.Resources
{
    public class AuthenticationProviderThatSupportsGroups
    {
        public string Id => Name;

        public string Name { get; set; } = string.Empty;

        public bool IsRoleBased { get; set; }

        public bool SupportsGroupLookup { get; set; }
        public string LookupUri { get; set; } = string.Empty;
    }
}