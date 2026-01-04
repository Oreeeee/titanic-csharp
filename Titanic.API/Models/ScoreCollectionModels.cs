using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Titanic.API.Models
{
    public class ScoreCollectionResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("scores")]
        public List<ScoreModelWithoutUser> Scores { get; set; }
    }

    public class ScoreCollectionResponseCompact
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("scores")]
        public List<ScoreModelWithoutBeatmap> Scores { get; set; }
    }
}
