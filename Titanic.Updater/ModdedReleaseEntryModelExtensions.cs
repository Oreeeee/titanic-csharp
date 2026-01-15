using Titanic.API.Http;
using Titanic.API.Models;

namespace Titanic.Updater;

public static class ModdedReleaseEntryModelExtensions
{
    extension(ModdedReleaseEntryModel entry) {
        public bool IsExtractable =>
            !string.IsNullOrEmpty(entry.DownloadUrl) &&
            entry.DownloadUrl.EndsWith(".zip") &&
            Uri.TryCreate(entry.DownloadUrl, UriKind.Absolute, out _);

        public bool IsMediafireDownload =>
            !string.IsNullOrEmpty(entry.DownloadUrl) &&
            Uri.TryCreate(entry.DownloadUrl, UriKind.Absolute, out Uri? uri) &&
            uri.Host.Contains("mediafire.com");

        public bool ResolveDownloadUrl()
        {
            if (!entry.IsMediafireDownload)
                return false;

            IHttpInterface http = HttpInterfaceFactory.Create("https://mediafire.com");
            MediaFireDownloader downloader = new MediaFireDownloader(http);

            MediaFireDownloader.DownloadItem? downloadItem = downloader.FetchDirectDownloadUrl(entry.DownloadUrl);
            if (downloadItem == null)
                return false;

            entry.DownloadUrl = downloadItem.DownloadUrl;
            return true;
        }
    }
}