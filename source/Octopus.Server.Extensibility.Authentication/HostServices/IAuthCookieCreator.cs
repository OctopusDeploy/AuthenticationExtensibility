using System;
using Nancy;
using Nancy.Cookies;

namespace Octopus.Server.Extensibility.Authentication.HostServices
{
    public interface IAuthCookieCreator
    {
        INancyCookie[] CreateAuthCookies(Request request, Guid token, SessionExpiry expiry);
    }
}