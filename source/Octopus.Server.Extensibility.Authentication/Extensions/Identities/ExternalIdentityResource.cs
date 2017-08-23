namespace Octopus.Server.Extensibility.Authentication.Extensions.Identities
{
    public abstract class ExternalIdentityResource : IdentityResource
    {
        public string EmailAddress { get; set; }
    }
}