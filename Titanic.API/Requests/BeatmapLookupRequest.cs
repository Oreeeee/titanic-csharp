using System;
using System.Collections.Generic;
using System.Text;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class BeatmapLookupRequest : APIRequest<BeatmapModel>
    {
        public string Query { get; set; }

        public BeatmapLookupRequest(string query)
        {
            Query = query;
        }

        protected override BeatmapModel Execute(TitanicAPI api)
        {
            return api.Get<BeatmapModel>($"/beatmaps/lookup/{Query}");
        }
    }
}
