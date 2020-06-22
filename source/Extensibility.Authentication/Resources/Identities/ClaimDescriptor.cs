namespace Octopus.Server.Extensibility.Authentication.Resources.Identities
{
    public class ClaimDescriptor
    {
        public const string EmailClaimType = "email";
        public const string DisplayNameClaimType = "dn";

        public string Type { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public bool IsIdentifyingClaim { get; set; }
    }
}