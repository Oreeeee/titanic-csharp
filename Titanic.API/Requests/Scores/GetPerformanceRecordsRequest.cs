using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetPerformanceRecordsRequest : APIRequest<ScoreRecordsModel>
    {
        protected override ScoreRecordsModel Execute(TitanicAPI api)
        {
            return api.Get<ScoreRecordsModel>("/scores/records/performance");
        }
    }
}
