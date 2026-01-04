using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class BeatmapPackModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("download_link")]
        public string DownloadLink { get; set; }

        [JsonProperty("creator")]
        public UserModelCompact Creator { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    public class BeatmapPackWithEntriesModel : BeatmapPackModel
    {
        [JsonProperty("entries")]
        public List<BeatmapPackEntryModel> Entries { get; set; }
    }

    public class BeatmapPackEntryModel
    {
        [JsonProperty("beatmapset")]
        public BeatmapSetModel Beatmapset { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}