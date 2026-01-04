using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class NotificationModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }
    }
}
