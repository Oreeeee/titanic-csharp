using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class UserModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("latest_activity")]
        public DateTime LatestActivity { get; set; }

        [JsonProperty("silence_end")]
        public DateTime? SilenceEnd { get; set; }

        [JsonProperty("restricted")]
        public bool Restricted { get; set; }

        [JsonProperty("activated")]
        public bool Activated { get; set; }

        [JsonProperty("preferred_mode")]
        public int PreferredMode { get; set; }

        [JsonProperty("playstyle")]
        public int Playstyle { get; set; }

        [JsonProperty("userpage")]
        public string Userpage { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("banner")]
        public string Banner { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("discord")]
        public string Discord { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("interests")]
        public string Interests { get; set; }

        [JsonProperty("relationships")]
        public List<RelationshipModel> Relationships { get; set; }

        [JsonProperty("achievements")]
        public List<AchievementModel> Achievements { get; set; }

        [JsonProperty("names")]
        public List<NameHistoryModel> Names { get; set; }

        [JsonProperty("badges")]
        public List<BadgeModel> Badges { get; set; }

        [JsonProperty("stats")]
        public List<StatsModel> Stats { get; set; }

        [JsonProperty("groups")]
        public List<GroupEntryModel> Groups { get; set; }
    }
}
