using System;
using Octopus.TinyTypes;

namespace Octopus.Server.Extensibility.Authentication.HostServices
{ 
    public class SessionExpiry: TinyType<int>
    {
        public SessionExpiry(int seconds) : base(seconds)
        {
        }
    }
}