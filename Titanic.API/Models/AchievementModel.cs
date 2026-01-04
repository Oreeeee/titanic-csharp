using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{

    public class AchievementModel
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("unlocked_at")]
        public DateTime UnlockedAt { get; set; }
    }
}
