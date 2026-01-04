using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetModdedReleaseRequest : APIRequest<ModdedReleaseModel>
    {
        public string Identifier { get; set; }

        public GetModdedReleaseRequest(string identifier)
        {
            Identifier = identifier;
        }

        protected override ModdedReleaseModel Execute(TitanicAPI api)
        {
            return api.Get<ModdedReleaseModel>($"/releases/modded/{Identifier}");
        }
    }
}
