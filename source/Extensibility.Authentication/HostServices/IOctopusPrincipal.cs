using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace Octopus.Server.Extensibility.Authentication.HostServices
{
    public interface IOctopusPrincipal : IPrincipal, IIdentity
    {
        string Id { get; }
        string Username { get; }
        string DisplayName { get; }
        string EmailAddress { get; }
        Guid IdentificationToken { get; }
        bool IsActive { get; }
        string EstablishedWith { get; }
        bool IsInAnyTeam(IEnumerable<string> teamIds);
        bool IsInTeam(string teamId);
        IList<string> GetTeams();
    }
}