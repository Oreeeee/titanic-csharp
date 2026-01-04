using System.Collections.Generic;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class BeatmapNominationResetRequest : APIRequest<List<NominationModel>>
    {
        public int SetId { get; }

        public BeatmapNominationResetRequest(int setId)
        {
            SetId = setId;
        }

        protected override List<NominationModel> Execute(TitanicAPI api)
        {
            return api.Delete<List<NominationModel>>($"/beatmapsets/{SetId}/nominations");
        }
    }
}
