using Octopus.Data.Model.User;

namespace Octopus.Server.Extensibility.Authentication.HostServices
{
    public class UserFindAndUpdateResult
    {
        public UserFindAndUpdateResult(IUser user)
        {
            User = user;
            Succeeded = true;
        }

        public UserFindAndUpdateResult(string failureReason)
        {
            FailureReason = failureReason;
        }

        public bool Succeeded { get; private set; }
        public IUser User { get; private set; }
        public string FailureReason { get; private set; }
    }
}