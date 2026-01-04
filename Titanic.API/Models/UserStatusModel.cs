using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class UserStatusModel
    {
        [JsonProperty("action")]
        public int Action { get; set; }

        [JsonProperty("version")]
        public int? Version { get; set; }

        [JsonProperty("mode")]
        public int Mode { get; set; }

        [JsonProperty("mods")]
        public int Mods { get; set; }

        [JsonProperty("beatmap_id")]
        public int BeatmapId { get; set; }

        [JsonProperty("beatmap")]
        public BeatmapModel Beatmap { get; set; }
    }
}
