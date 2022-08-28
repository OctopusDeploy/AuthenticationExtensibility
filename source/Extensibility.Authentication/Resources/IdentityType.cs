using System;

namespace Octopus.Server.Extensibility.Authentication.Resources;

public enum IdentityType
{
    Guest,
    UsernamePassword,
    ActiveDirectory,
    OAuth
}