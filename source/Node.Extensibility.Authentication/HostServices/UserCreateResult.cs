using System;
using Octopus.Data.Model.User;

namespace Octopus.Node.Extensibility.Authentication.HostServices
{
    public class UserCreateResult
    {
        public UserCreateResult(IUser user)
        {
            Succeeded = user != null;
            User = user;
        }

        public UserCreateResult(string failureReason)
        {
            if (string.IsNullOrWhiteSpace(failureReason))
                throw new ArgumentException("User creation failure reason not provided", nameof(failureReason));
            FailureReason = failureReason;
        }

        public UserCreateResult(UserCreateResult copyFrom)
        {
            Succeeded = copyFrom.Succeeded;
            User = copyFrom.User;
            FailureReason = copyFrom.FailureReason;
        }

        public bool Succeeded { get; private set; }
        public IUser User { get; private set; }
        public string FailureReason { get; private set; }
    }
}