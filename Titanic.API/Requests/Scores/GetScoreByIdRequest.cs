using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetScoreByIdRequest : APIRequest<ScoreModel>
    {
        public long ScoreId { get; set; }

        public GetScoreByIdRequest(long scoreId)
        {
            ScoreId = scoreId;
        }

        protected override ScoreModel Execute(TitanicAPI api)
        {
            return api.Get<ScoreModel>($"/scores/{ScoreId}");
        }
    }
}
