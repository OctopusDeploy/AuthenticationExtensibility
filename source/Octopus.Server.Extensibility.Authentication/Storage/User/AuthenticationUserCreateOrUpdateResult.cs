using Octopus.Data.Model.User;
using Octopus.Data.Storage.User;

namespace Octopus.Server.Extensibility.Authentication.Storage.User
{
    public class AuthenticationUserCreateOrUpdateResult : UserCreateOrUpdateResult
    {
        public AuthenticationUserCreateOrUpdateResult() : base((string)null)
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