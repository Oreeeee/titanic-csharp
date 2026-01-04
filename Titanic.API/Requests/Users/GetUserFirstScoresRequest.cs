using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetUserFirstScoresRequest : APIRequest<ScoreCollectionResponse>
    {
        public int UserId { get; set; }
        public int? Mode { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }

        public GetUserFirstScoresRequest(int userId, int? mode = null, int offset = 0, int limit = 50)
        {
            UserId = userId;
            Mode = mode;
            Offset = offset;
            Limit = limit;
        }

        protected override ScoreCollectionResponse Execute(TitanicAPI api)
        {
            string endpoint = Mode.HasValue
                ? $"/users/{UserId}/first/{Mode.Value}?offset={Offset}&limit={Limit}"
                : $"/users/{UserId}/first?offset={Offset}&limit={Limit}";
            return api.Get<ScoreCollectionResponse>(endpoint);
        }
    }
}
