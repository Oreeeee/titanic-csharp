using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class FavouritesModel
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("set_id")]
        public int SetId { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
