using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class RankingEntryModel
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("user")]
        public UserModelWithStats User { get; set; }
    }

    public class CountryEntryModel
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stats")]
        public CountryStatsModel Stats { get; set; }
    }

    public class CountryStatsModel
    {
        [JsonProperty("average_performance")]
        public double AveragePerformance { get; set; }

        [JsonProperty("total_performance")]
        public long TotalPerformance { get; set; }

        [JsonProperty("total_rscore")]
        public long TotalRankedScore { get; set; }

        [JsonProperty("total_tscore")]
        public long TotalTotalScore { get; set; }

        [JsonProperty("total_users")]
        public int TotalUsers { get; set; }
    }

    public class ScoreRecordsModel
    {
        [JsonProperty("osu")]
        public ScoreModel Osu { get; set; }

        [JsonProperty("taiko")]
        public ScoreModel Taiko { get; set; }

        [JsonProperty("ctb")]
        public ScoreModel Ctb { get; set; }

        [JsonProperty("mania")]
        public ScoreModel Mania { get; set; }
    }
}
