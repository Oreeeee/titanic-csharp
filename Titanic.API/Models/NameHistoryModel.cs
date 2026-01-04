using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class NameHistoryModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("changed_at")]
        public DateTime ChangedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
