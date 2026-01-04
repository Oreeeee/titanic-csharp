
using System;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class FavouriteModel
    {
        [JsonProperty("user")]
        public UserModelCompact User { get; set; }

        [JsonProperty("beatmapset")]
        public BeatmapSetModel Beatmapset { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public class FavouriteCreateRequest
    {
        [JsonProperty("set_id")]
        public int SetId { get; set; }
    }
}