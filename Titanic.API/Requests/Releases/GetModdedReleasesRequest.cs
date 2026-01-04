using System.Collections.Generic;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetModdedReleasesRequest : APIRequest<List<ModdedReleaseModel>>
    {
        protected override List<ModdedReleaseModel> Execute(TitanicAPI api)
        {
            return api.Get<List<ModdedReleaseModel>>("/releases/modded");
        }
    }
}
