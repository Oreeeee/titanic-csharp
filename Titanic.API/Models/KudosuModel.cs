using System;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class KudosuModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("post_id")]
        public int PostId { get; set; }

        [JsonProperty("sender_id")]
        public int SenderId { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("action")]
        public int Action { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }
    }
}
