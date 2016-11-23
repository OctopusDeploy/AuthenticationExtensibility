
using System.Linq;

namespace Octopus.Server.Extensibility.Authentication.HostServices
{
    public static class Requests
    {
        [ObsoleteEx(TreatAsErrorFromVersion = "2.0", RemoveInVersion = "2.0", ReplacementTypeOrMember = "IsLocalUrl")]
        public static bool IsLocalUrl(string absoluteVirtualDirectoryPath, string url, string[] whitelist)
        {
            return IsLocalUrl(url, whitelist);
        }

        public static bool IsLocalUrl(string url, string[] whitelist)
        {
            // Credit to Microsoft - Preventing Open Redirection Attacks (C#)
            // http://www.asp.net/mvc/overview/security/preventing-open-redirection-attacks

            var isLocalUrl = !string.IsNullOrEmpty(url) &&

                             // Allows paths on the corsWhitelist, if one is defined
                             ((whitelist != null && whitelist.Length > 0 && whitelist.Where(u => !string.IsNullOrWhiteSpace(u)).Any(url.StartsWith)) ||

                             // Allows "/" or "/foo" but not "//" or "/\".
                             (url[0] == '/' && (url.Length == 1 || (url[1] != '/' && url[1] != '\\'))) ||

                             // Allows "~/" or "~/foo".
                             (url.Length > 1 && url[0] == '~' && url[1] == '/'));

            return isLocalUrl;
        }
    }
}