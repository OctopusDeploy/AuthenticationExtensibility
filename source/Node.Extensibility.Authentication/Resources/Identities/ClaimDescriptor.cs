namespace Octopus.Node.Extensibility.Authentication.Resources.Identities
{
    public class ClaimDescriptor
    {
        public const string EmailClaimType = "email";
        public const string DisplayNameClaimType = "dn";

        public string Type { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }

        public bool IsIdentifyingClaim { get; set; }
    }
}