using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class RequestErrorModel
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }
    }
}
