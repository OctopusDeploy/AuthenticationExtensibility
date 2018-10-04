using System;
using Octopus.Node.Extensibility.Authentication.HostServices;
using Octopus.Server.Extensibility.Extensions.Infrastructure.Web.Api;

namespace Octopus.Server.Extensibility.Authentication.HostServices
{
    public interface IAuthCookieCreator
    {
        OctoCookie[] CreateAuthCookies(Guid token, SessionExpiry expiry, bool requestAppearsToBeHttps,
            bool? forceSecureCookie = null);
    }
}