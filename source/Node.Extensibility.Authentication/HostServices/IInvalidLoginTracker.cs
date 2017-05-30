namespace Octopus.Node.Extensibility.Authentication.HostServices
{
    public interface IInvalidLoginTracker : ILoginRecorder
    {
        InvalidLoginAction BeforeAttempt(string attemptedUsername, string ipAddress);
    }
}