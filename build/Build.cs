using System;

[CheckBuildProjectConfigurations]
[UnsetVisualStudioEnvironmentVariables]
class Build : NukeBuild
{
    /// Support plugins are available for:
    /// - JetBrains ReSharper        https://nuke.build/resharper
    /// - JetBrains Rider            https://nuke.build/rider
    /// - Microsoft VisualStudio     https://nuke.build/visualstudio
    /// - Microsoft VSCode           https://nuke.build/vscode
    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;
    // readonly Configuration Configuration = Configuration.Release;

    [Solution(GenerateProjects = true)] readonly Solution Solution;

    [Parameter("Whether to auto-detect the branch name - this is okay for a local build, but should not be used under CI.")] readonly bool AutoDetectBranch = IsLocalBuild;

    [Parameter("Branch name for OctoVersion to use to calculate the version number. Can be set via the environment variable OCTOVERSION_CurrentBranch.",
        Name = "OCTOVERSION_CurrentBranch")]
    readonly string BranchName;

    [OctoVersion(UpdateBuildNumber = true, BranchParameter = nameof(BranchName),
        AutoDetectBranchParameter = nameof(AutoDetectBranch), Framework = "net6.0")]
    readonly OctoVersionInfo OctoVersionInfo;

    static AbsolutePath SourceDirectory => RootDirectory / "source";
    static AbsolutePath ArtifactsDirectory => RootDirectory / "artifacts";
    static AbsolutePath LocalPackagesDir => RootDirectory / ".." / "LocalPackages";

    Target Clean => _ => _
        .Executes(() =>
        {
            SourceDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
            EnsureCleanDirectory(ArtifactsDirectory);
        });

    Target Restore => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            DotNetRestore(_ => _
                .SetProjectFile(Solution));
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            DotNetBuild(_ => _
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .SetVersion(OctoVersionInfo.FullSemVer)
                .SetInformationalVersion(OctoVersionInfo.InformationalVersion)
                .EnableNoRestore());
        });

    [PublicAPI]
    Target Test => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            DotNetTest(_ => _
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .EnableNoBuild()
                .EnableNoRestore());
        });

    Target Pack => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            DotNetPack(_ => _
                .SetProject(Solution)
                .SetVersion(OctoVersionInfo.FullSemVer)
                .SetConfiguration(Configuration)
                .SetOutputDirectory(ArtifactsDirectory)
                .EnableNoBuild()
                .DisableIncludeSymbols()
                .SetVerbosity(DotNetVerbosity.Normal));
        });

    Target CopyToLocalPackages => _ => _
        .OnlyWhenStatic(() => IsLocalBuild)
        .TriggeredBy(Pack)
        .Executes(() =>
        {
            EnsureExistingDirectory(LocalPackagesDir);
            ArtifactsDirectory.GlobFiles("*.nupkg")
                .ForEach(package => CopyFileToDirectory(package, LocalPackagesDir, FileExistsPolicy.Overwrite));
        });

    Target Default => _ => _
        .DependsOn(Pack)
        .DependsOn(CopyToLocalPackages);

    public static int Main() => Execute<Build>(x => x.Default);
}