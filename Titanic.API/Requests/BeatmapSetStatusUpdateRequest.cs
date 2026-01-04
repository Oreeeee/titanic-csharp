using System;
using System.Collections.Generic;
using System.Text;
using Titanic.API.Models;
using Titanic.API.Constants;

namespace Titanic.API.Requests
{
    public class BeatmapSetStatusUpdateRequest : APIRequest<BeatmapSetModel>
    {
        public int SetId { get; set; }
        public OnlineBeatmapStatus Status { get; set; }

        public BeatmapSetStatusUpdateRequest(int setId, OnlineBeatmapStatus status)
        {
            SetId = setId;
            Status = status;
        }

        protected override BeatmapSetModel Execute(TitanicAPI api)
        {
            return api.Patch<BeatmapSetModel>($"/beatmapsets/{SetId}/status?status={(int)(Status)}", null);
        }
    }
}
