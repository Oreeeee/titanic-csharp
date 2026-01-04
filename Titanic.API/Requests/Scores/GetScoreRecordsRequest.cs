using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetScoreRecordsRequest : APIRequest<ScoreRecordsModel>
    {
        protected override ScoreRecordsModel Execute(TitanicAPI api)
        {
            return api.Get<ScoreRecordsModel>("/scores/records/score");
        }
    }
}
