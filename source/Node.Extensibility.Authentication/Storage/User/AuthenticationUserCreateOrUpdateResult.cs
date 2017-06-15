﻿using Octopus.Data.Model.User;
using Octopus.Node.Extensibility.Authentication.HostServices;

namespace Octopus.Node.Extensibility.Authentication.Storage.User
{
    public class AuthenticationUserCreateOrUpdateResult : UserCreateOrUpdateResult
    {
        public AuthenticationUserCreateOrUpdateResult() : base("Provider not enabled")
        {
            ProviderIsDisabled = true;
        }

        public AuthenticationUserCreateOrUpdateResult(string failureReason) : base(failureReason)
        {
        }

        public AuthenticationUserCreateOrUpdateResult(IUser user) : base(user)
        {
        }

        public AuthenticationUserCreateOrUpdateResult(UserCreateOrUpdateResult copyFrom) : base(copyFrom)
        {
        }

        public bool ProviderIsDisabled { get; private set; }
    }
}