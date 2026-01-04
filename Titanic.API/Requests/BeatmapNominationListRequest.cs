using System;
using System.Collections.Generic;
using System.Text;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class BeatmapNominationListRequest : APIRequest<List<NominationModel>>
    {
        public int SetId { get; set; }

        public BeatmapNominationListRequest(int setId)
        {
            SetId = setId;
        }

        protected override List<NominationModel> Execute(TitanicAPI api)
        {
            return api.Get<List<NominationModel>> ($"/beatmapsets/{SetId}/nominations");
        }
    }
}
