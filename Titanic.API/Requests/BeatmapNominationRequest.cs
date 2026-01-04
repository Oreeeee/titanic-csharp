using System;
using System.Collections.Generic;
using System.Text;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class BeatmapNominationRequest : APIRequest<List<NominationModel>>
    {
        public int SetId { get; set; }

        public BeatmapNominationRequest(int setId)
        {
            SetId = setId;
        }

        protected override List<NominationModel> Execute(TitanicAPI api)
        {
            return api.Post<List<NominationModel>>($"/beatmapsets/{SetId}/nominations", null);
        }
    }
}
