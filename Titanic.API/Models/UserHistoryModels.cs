using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class UserRankHistoryModel
    {
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("mode")]
        public int Mode { get; set; }

        [JsonProperty("rscore")]
        public long RankedScore { get; set; }

        [JsonProperty("pp")]
        public int? PP { get; set; }

        [JsonProperty("ppv1")]
        public int? PPv1 { get; set; }

        [JsonProperty("global_rank")]
        public int? GlobalRank { get; set; }

        [JsonProperty("country_rank")]
        public int? CountryRank { get; set; }

        [JsonProperty("score_rank")]
        public int? ScoreRank { get; set; }

        [JsonProperty("score_rank_country")]
        public int? ScoreRankCountry { get; set; }

        [JsonProperty("ppv1_rank")]
        public int? PPv1Rank { get; set; }

        [JsonProperty("ppv1_rank_country")]
        public int? PPv1RankCountry { get; set; }
    }

    public class UserPlaysHistoryModel
    {
        [JsonProperty("mode")]
        public int Mode { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("plays")]
        public int Plays { get; set; }
    }

    public class UserReplayHistoryModel
    {
        [JsonProperty("mode")]
        public int Mode { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("replay_views")]
        public int ReplayViews { get; set; }
    }

    public class UserBeatmapPlaysModel
    {
        [JsonProperty("beatmap")]
        public BeatmapModel Beatmap { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
