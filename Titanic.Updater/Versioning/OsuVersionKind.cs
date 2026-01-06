namespace Titanic.Updater.Versioning;

public enum OsuVersionKind
{
    /// <summary>
    /// e.g. 1.6.2
    /// </summary>
    Semver,
    /// <summary>
    /// e.g. b597
    /// </summary>
    BuildNumber,
    /// <summary>
    /// e.g. 20250815
    /// </summary>
    BuildDate,
}