using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetUserPinnedScoresRequest : APIRequest<ScoreCollectionResponse>
    {
        public int UserId { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }

        public GetUserPinnedScoresRequest(int userId, int offset = 0, int limit = 50)
        {
            UserId = userId;
            Offset = offset;
            Limit = limit;
        }

        protected override ScoreCollectionResponse Execute(TitanicAPI api)
        {
            return api.Get<ScoreCollectionResponse>($"/users/{UserId}/pinned?offset={Offset}&limit={Limit}");
        }
    }
}
