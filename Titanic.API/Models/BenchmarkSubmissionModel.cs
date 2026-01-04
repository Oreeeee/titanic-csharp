using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class BenchmarkSubmissionModel
    {
        [JsonProperty("smoothness")]
        public float Smoothness { get; set; }

        [JsonProperty("framerate")]
        public int Framerate { get; set; }

        [JsonProperty("raw_score")]
        public int RawScore { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("hardware")]
        public BenchmarkHardwareModel Hardware { get; set; }
    }
}
