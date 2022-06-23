using System;
using Octopus.Server.MessageContracts;

namespace Octopus.Server.Extensibility.Authentication.Resources.Identities;

public class IdentityMetadataResource
{
    public string IdentityProviderName { get; set; } = string.Empty;

    public ClaimDescriptor[] ClaimDescriptors { get; set; } = Array.Empty<ClaimDescriptor>();

    public LinkCollection Links { get; set; } = new();
}