using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetBeatmapPackRequest : APIRequest<BeatmapPackWithEntriesModel>
    {
        public string Category { get; set; }
        public int PackId { get; set; }

        public GetBeatmapPackRequest(string category, int packId)
        {
            Category = category;
            PackId = packId;
        }

        protected override BeatmapPackWithEntriesModel Execute(TitanicAPI api)
        {
            return api.Get<BeatmapPackWithEntriesModel>($"/beatmapsets/packs/{Category}/{PackId}");
        }
    }
}
