using System;
using Nancy;
using Nancy.Cookies;
using Octopus.Node.Extensibility.Authentication.HostServices;

namespace Octopus.Server.Extensibility.Authentication.HostServices
{
    public interface IAuthCookieCreator
    {
        //ObsoleteEx INancyCookie CreateAuthCookie(NancyContext context, Guid token, bool persistant);
        INancyCookie[] CreateAuthCookies(Request request, Guid token, SessionExpiry expiry);
    }
}