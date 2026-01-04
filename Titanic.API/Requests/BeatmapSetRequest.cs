using System;
using System.Collections.Generic;
using System.Text;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    internal class BeatmapSetRequest : APIRequest<BeatmapSetModel>
    {
        public int SetId { get; }

        public BeatmapSetRequest(int setId)
        {
            SetId = setId;
        }

        protected override BeatmapSetModel Execute(TitanicAPI api)
        {
            return api.Get<BeatmapSetModel>($"/beatmapsets/{SetId}");
        }
    }
}
