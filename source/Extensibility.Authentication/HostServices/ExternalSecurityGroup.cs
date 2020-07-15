namespace Octopus.Server.Extensibility.Authentication.HostServices
{
    public class ExternalSecurityGroup
    {
        /// <summary>
        /// The identifier for the group/role.  For roles this will usually be their name, for groups it'll be a sid.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        public string DisplayName { get; set; } = string.Empty;

        public bool DisplayIdAndName { get; set; }
    }
}