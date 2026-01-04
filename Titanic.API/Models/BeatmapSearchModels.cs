using System;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class BeatmapSearchRequest
    {
        [JsonProperty("language")]
        public int? Language { get; set; }

        [JsonProperty("genre")]
        public int? Genre { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("mode")]
        public int? Mode { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("page")]
        public int? Page { get; set; }

        [JsonProperty("sort")]
        public int? Sort { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("titanic")]
        public bool Titanic { get; set; }
    }
}
