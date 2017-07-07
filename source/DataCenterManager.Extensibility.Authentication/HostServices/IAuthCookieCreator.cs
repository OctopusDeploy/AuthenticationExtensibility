using System;
using Microsoft.AspNetCore.Http;
using Octopus.Node.Extensibility.Authentication.HostServices;

namespace Octopus.DataCenterManager.Extensibility.Authentication.HostServices
{
    public interface IAuthCookieCreator
    {
        void CreateAuthCookies(HttpResponse response, Guid token, SessionExpiry expiry);
    }
}