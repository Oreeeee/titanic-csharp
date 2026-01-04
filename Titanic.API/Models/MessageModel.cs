#nullable enable
using System;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class MessageModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sender")]
        public UserModel? Sender { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; } = string.Empty;

        [JsonProperty("time")]
        public DateTime CreatedAt { get; set; }
    }
}
