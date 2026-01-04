using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetMatchRequest : APIRequest<MultiplayerMatchModel>
    {
        public int MatchId { get; set; }

        public GetMatchRequest(int matchId)
        {
            MatchId = matchId;
        }

        protected override MultiplayerMatchModel Execute(TitanicAPI api)
        {
            return api.Get<MultiplayerMatchModel>($"/multiplayer/{MatchId}");
        }
    }
}
