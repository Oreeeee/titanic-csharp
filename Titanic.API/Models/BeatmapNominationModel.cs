using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class BeatmapNominationModel
    {
        [JsonProperty("set_id")]
        public int SetId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("user")]
        public UserModel User { get; set; }
    }
}
