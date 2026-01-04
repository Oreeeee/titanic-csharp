using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetUserRecentScoresRequest : APIRequest<ScoreCollectionResponse>
    {
        public int UserId { get; set; }
        public int? Mode { get; set; }
        public int Limit { get; set; }
        public int MinStatus { get; set; }

        public GetUserRecentScoresRequest(int userId, int? mode = null, int limit = 5, int minStatus = 0)
        {
            UserId = userId;
            Mode = mode;
            Limit = limit;
            MinStatus = minStatus;
        }

        protected override ScoreCollectionResponse Execute(TitanicAPI api)
        {
            string endpoint = Mode.HasValue
                ? $"/users/{UserId}/recent/{Mode.Value}?limit={Limit}&min_status={MinStatus}"
                : $"/users/{UserId}/recent?limit={Limit}&min_status={MinStatus}";
            return api.Get<ScoreCollectionResponse>(endpoint);
        }
    }
}
