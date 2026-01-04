using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{

    public class BadgeModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("badge_icon")]
        public string BadgeIcon { get; set; }

        [JsonProperty("badge_url")]
        public string BadgeUrl { get; set; }

        [JsonProperty("badge_description")]
        public string BadgeDescription { get; set; }
    }
}
