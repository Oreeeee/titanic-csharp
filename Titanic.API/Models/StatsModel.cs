using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class StatsModel
    {
        [JsonProperty("mode")]
        public int Mode { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("tscore")]
        public Int64 TotalScore { get; set; }

        [JsonProperty("rscore")]
        public Int64 RankedScore { get; set; }

        [JsonProperty("pp")]
        public float PP { get; set; }

        [JsonProperty("ppv1")]
        public float PPv1 { get; set; }

        [JsonProperty("playcount")]
        public int Playcount { get; set; }

        [JsonProperty("playtime")]
        public int Playtime { get; set; }

        [JsonProperty("acc")]
        public float Accuracy { get; set; }

        [JsonProperty("max_combo")]
        public int MaxCombo { get; set; }

        [JsonProperty("total_hits")]
        public int TotalHits { get; set; }

        [JsonProperty("replay_views")]
        public int ReplayViews { get; set; }

        [JsonProperty("xh_count")]
        public int XHCount { get; set; }

        [JsonProperty("x_count")]
        public int XCount { get; set; }

        [JsonProperty("sh_count")]
        public int SHCount { get; set; }

        [JsonProperty("s_count")]
        public int SCount { get; set; }

        [JsonProperty("a_count")]
        public int ACount { get; set; }

        [JsonProperty("b_count")]
        public int BCount { get; set; }

        [JsonProperty("c_count")]
        public int CCount { get; set; }

        [JsonProperty("d_count")]
        public int DCount { get; set; }
    }
}
