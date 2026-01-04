using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class BeatmapSetMetadataUpdateRequest : APIRequest<BeatmapSetModel>
    {
        private readonly int setId;
        private readonly BeatmapSetMetadataUpdateModel metadata;

        public BeatmapSetMetadataUpdateRequest(int setId, BeatmapSetMetadataUpdateModel metadata)
        {
            this.setId = setId;
            this.metadata = metadata;
        }

        protected override BeatmapSetModel Execute(TitanicAPI api)
        {
            return api.Patch<BeatmapSetModel>($"/beatmapsets/{setId}", metadata);
        }
    }
}
