using Titanic.Updater.Versioning;

namespace Titanic.Updater;

public class ModdedClientInformation
{
    /// <summary>
    /// The identifier for the modded osu! client
    /// </summary>
    public string ClientIdentifier = string.Empty;

    /// <summary>
    /// The versioning scheme used for the modded osu! client. Leave blank if building an application that lists modded clients.
    /// </summary>
    public OsuVersionKind? VersionKind = null;

    /// <summary>
    /// The active release stream of the client, if installed on this system.
    /// </summary>
    public string? InstalledStream;
    /// <summary>
    /// The current version of the client, if installed on this system.
    /// </summary>
    public string? InstalledVersion;
}