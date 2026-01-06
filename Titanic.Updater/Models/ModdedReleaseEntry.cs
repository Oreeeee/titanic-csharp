namespace Titanic.Updater.Models;

#nullable disable

public class ModdedReleaseEntry
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("mod_name")]
    public string ModName { get; set; }

    [JsonProperty("version")]
    public string Version { get; set; }

    [JsonProperty("stream")]
    public string Stream { get; set; }

    [JsonProperty("checksum")]
    public string Checksum { get; set; }

    [JsonProperty("download_url")]
    public string DownloadUrl { get; set; }

    [JsonProperty("changelog")]
    public string Changelog { get; set; }

    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }

    public bool IsExtractable =>
        !string.IsNullOrEmpty(this.DownloadUrl) &&
        this.DownloadUrl.EndsWith(".zip") &&
        Uri.TryCreate(this.DownloadUrl, UriKind.Absolute, out _);
}