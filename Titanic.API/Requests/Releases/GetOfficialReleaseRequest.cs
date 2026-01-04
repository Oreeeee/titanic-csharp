using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetOfficialReleaseRequest : APIRequest<OsuReleaseModel>
    {
        public int ReleaseId { get; set; }

        public GetOfficialReleaseRequest(int releaseId)
        {
            ReleaseId = releaseId;
        }

        protected override OsuReleaseModel Execute(TitanicAPI api)
        {
            return api.Get<OsuReleaseModel>($"/releases/official/{ReleaseId}");
        }
    }
}
