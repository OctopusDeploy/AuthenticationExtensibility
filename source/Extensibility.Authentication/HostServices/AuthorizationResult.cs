using System;

namespace Octopus.Server.Extensibility.Authentication.HostServices;

public class AuthorizationResult
{
    readonly Lazy<string> helpText;

    public AuthorizationResult(bool isAuthorized, Lazy<string>? helpText = null)
    {
        IsAuthorized = isAuthorized;
        this.helpText = helpText ?? new Lazy<string>(() => string.Empty);
    }

    public bool IsAuthorized { get; }

    public string? HelpText => helpText.Value;
}