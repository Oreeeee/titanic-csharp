using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Titanic.API.Constants;

namespace Titanic.API.Models
{
    public class BeatmapSetModelCompact
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("status")]
        public OnlineBeatmapStatus Status { get; set; }
    }

    public class BeatmapSetModel : BeatmapModelCompact
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("language_id")]
        public int LanguageId { get; set; }

        [JsonProperty("genre_id")]
        public int GenreId { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("display_title")]
        public string DisplayTitle { get; set; }

        [JsonProperty("beatmaps")]
        public List<BeatmapModelCompact> Beatmaps { get; set; }
    }
}
