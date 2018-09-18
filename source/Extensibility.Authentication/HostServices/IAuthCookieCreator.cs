using System;
using Octopus.Node.Extensibility.Authentication.HostServices;

namespace Octopus.Server.Extensibility.Authentication.HostServices
{
    public interface IAuthCookieCreator
    {
        OctoCookie[] CreateAuthCookies(Guid token, SessionExpiry expiry, bool requestAppearsToBeHttps,
            bool? forceSecureCookie = null);
    }
}