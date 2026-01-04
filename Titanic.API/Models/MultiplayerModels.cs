using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class MultiplayerMatchModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("ended_at")]
        public DateTime? EndedAt { get; set; }

        [JsonProperty("creator")]
        public UserModel Creator { get; set; }

        [JsonProperty("events")]
        public List<MultiplayerMatchEventModel> Events { get; set; }
    }

    public class MultiplayerMatchEventModel
    {
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, object> Data { get; set; }
    }
}
