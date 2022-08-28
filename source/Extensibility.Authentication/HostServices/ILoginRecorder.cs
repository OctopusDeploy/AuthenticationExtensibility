using System;

namespace Octopus.Server.Extensibility.Authentication.HostServices;

public interface ILoginRecorder
{
    void RecordFailure(string attemptedUsername, string ipAddress);
    void RecordSucess(string attemptedUsername, string ipAddress);
}