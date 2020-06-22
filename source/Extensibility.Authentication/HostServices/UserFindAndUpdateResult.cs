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

        public bool Succeeded { get; }
        public IUser? User { get; }
        public string? FailureReason { get; }
    }
}