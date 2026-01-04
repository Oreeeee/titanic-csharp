using System;
using System.Collections.Generic;
using System.Text;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class BeatmapRequest : APIRequest<BeatmapModel>
    {
        public int BeatmapId { get; set; }

        public BeatmapRequest(int beatmapId)
        {
            BeatmapId = beatmapId;
        }

        protected override BeatmapModel Execute(TitanicAPI api)
        {
            return api.Get<BeatmapModel>($"/beatmaps/{BeatmapId}");
        }
    }
}
