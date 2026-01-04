using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class ServerStatsModel
    {
        [JsonProperty("uptime")]
        public int Uptime { get; set; }

        [JsonProperty("total_scores")]
        public int TotalScores { get; set; }

        [JsonProperty("total_users")]
        public int TotalUsers { get; set; }

        [JsonProperty("online_users")]
        public int OnlineUsers { get; set; }
    }
}
