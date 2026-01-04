using System;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class ScoreModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("submitted_at")]
        public DateTime SubmittedAt { get; set; }

        [JsonProperty("mode")]
        public int Mode { get; set; }

        [JsonProperty("status_pp")]
        public int StatusPP { get; set; }

        [JsonProperty("status_score")]
        public int StatusScore { get; set; }

        [JsonProperty("client_version")]
        public int ClientVersion { get; set; }

        [JsonProperty("client_string")]
        public string ClientString { get; set; }

        [JsonProperty("pp")]
        public float PP { get; set; }

        [JsonProperty("ppv1")]
        public float PPv1 { get; set; }

        [JsonProperty("acc")]
        public float Acc { get; set; }

        [JsonProperty("total_score")]
        public long TotalScore { get; set; }

        [JsonProperty("max_combo")]
        public int MaxCombo { get; set; }

        [JsonProperty("mods")]
        public int Mods { get; set; }

        [JsonProperty("perfect")]
        public bool Perfect { get; set; }

        [JsonProperty("passed")]
        public bool Passed { get; set; }

        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("n300")]
        public int Count300 { get; set; }

        [JsonProperty("n100")]
        public int Count100 { get; set; }

        [JsonProperty("n50")]
        public int Count50 { get; set; }

        [JsonProperty("nMiss")]
        public int CountMiss { get; set; }

        [JsonProperty("nGeki")]
        public int CountGeki { get; set; }

        [JsonProperty("nKatu")]
        public int CountKatu { get; set; }

        [JsonProperty("grade")]
        public string Grade { get; set; }

        [JsonProperty("replay_views")]
        public int ReplayViews { get; set; }

        [JsonProperty("failtime")]
        public int? Failtime { get; set; }

        [JsonProperty("beatmap")]
        public BeatmapModel Beatmap { get; set; }

        [JsonProperty("user")]
        public UserModel User { get; set; }
    }
}
