using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class ProfileUpdateModel
    {
        [JsonProperty("interests")]
        public string Interests { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("discord")]
        public string Discord { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }
    }

    public class PlaystyleRequestModel
    {
        [JsonProperty("playstyle")]
        public string Playstyle { get; set; }
    }

    public class PlaystyleResponseModel
    {
        [JsonProperty("playstyle")]
        public int Playstyle { get; set; }

        [JsonProperty("playstyles")]
        public List<string> Playstyles { get; set; }
    }
}
