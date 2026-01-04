using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class BeatmapSetMetadataUpdateModel
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("language")]
        public int Language { get; set; }

        [JsonProperty("genre")]
        public int Genre { get; set; }

        [JsonProperty("display_title")]
        public string DisplayTitle { get; set; }
    }
}
