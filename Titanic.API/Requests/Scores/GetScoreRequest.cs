using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetScoreRequest : APIRequest<ScoreModel>
    {
        private readonly long scoreId;

        public GetScoreRequest(long scoreId)
        {
            this.scoreId = scoreId;
        }

        protected override ScoreModel Execute(TitanicAPI api)
        {
            return api.Get<ScoreModel>($"/scores/{scoreId}");
        }
    }
}
