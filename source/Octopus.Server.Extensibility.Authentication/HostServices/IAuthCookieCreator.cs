using System;
using Nancy;
using Nancy.Cookies;

namespace Octopus.Server.Extensibility.Authentication.HostServices
{
    public interface IAuthCookieCreator
    {
        [ObsoleteEx(
            Message = "Sorry about the immediately breaking change! We are introducing CSRF prevention using the Cookie-To-Token pattern. Calling this method will only build the authentication cookie. Please change to use the CreateAuthCookies() method which will create the correct cookies for you to add on the outbound Response object.",
            RemoveInVersion = "3.1.0",
            TreatAsErrorFromVersion = "3.0.0",
            ReplacementTypeOrMember = "CreateAuthCookies")]
        INancyCookie CreateAuthCookie(NancyContext context, Guid token, bool persistant);
        INancyCookie[] CreateAuthCookies(NancyContext context, Guid token, SessionExpiry expiry);
    }
}