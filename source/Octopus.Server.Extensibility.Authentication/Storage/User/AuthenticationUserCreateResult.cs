using Octopus.Data.Model.User;
using Octopus.Server.Extensibility.Authentication.HostServices;

namespace Octopus.Server.Extensibility.Authentication.Storage.User
{
    public class AuthenticationUserCreateResult : UserCreateResult
    {
        public AuthenticationUserCreateResult() : base("Provider not enabled")
        {
            ProviderIsDisabled = true;
        }

        public AuthenticationUserCreateResult(string failureReason) : base(failureReason)
        {
        }

        public AuthenticationUserCreateResult(IUser user) : base(user)
        {
        }

        public AuthenticationUserCreateResult(UserCreateResult copyFrom) : base(copyFrom)
        {
        }

        public bool ProviderIsDisabled { get; private set; }
    }
}