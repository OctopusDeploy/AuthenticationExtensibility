using System;
using System.Collections.Generic;
using Octopus.Data.Model.User;

namespace Octopus.Server.Extensibility.Authentication.Extensions
{
    [ObsoleteEx(Message = "Groups are no longer checked by calling this method that updated the user details. Please use IExternalGroupRetriever to get the user's groups", ReplacementTypeOrMember = "IExternalGroupRetriever", RemoveInVersion = "4.0", TreatAsErrorFromVersion = "4.0")]
    public interface IExternalGroupsChecker
    {
        /// <summary>
        /// Checks the external group store and updates the user's external security groups.  May run
        /// the check on a background thread and return null in the meantime.
        /// </summary>
        /// <param name="user">The user to check groups for</param>
        /// <param name="forceRefresh">Forces an immediate refresh, on the foreground thread</param>
        /// <returns>The list of security group "ids".  For AD these would be sids, for OAuth these may be roles or sids</returns>
        HashSet<string> EnsureExternalSecurityGroupsAreUpToDate(IUser user, bool forceRefresh = false);
    }
}