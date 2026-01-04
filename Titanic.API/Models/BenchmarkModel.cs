using System;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class BenchmarkModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("smoothness")]
        public float Smoothness { get; set; }

        [JsonProperty("framerate")]
        public int Framerate { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("grade")]
        public string Grade { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("hardware")]
        public BenchmarkHardwareModel Hardware { get; set; }

        [JsonProperty("user")]
        public UserModel User { get; set; }
    }
}
