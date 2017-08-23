namespace Octopus.Server.Extensibility.Authentication.Extensions.Identities
{
    public abstract class IdentityResource
    {
        public abstract string Type { get; }

        public string Provider { get; set; }
    }
}