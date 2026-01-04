using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetUserTopScoresRequest : APIRequest<ScoreCollectionResponse>
    {
        public int UserId { get; set; }
        public int Mode { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }

        public GetUserTopScoresRequest(int userId, int mode, int offset = 0, int limit = 50)
        {
            UserId = userId;
            Mode = mode;
            Offset = offset;
            Limit = limit;
        }

        protected override ScoreCollectionResponse Execute(TitanicAPI api)
        {
            return api.Get<ScoreCollectionResponse>($"/users/{UserId}/top/{Mode}?offset={Offset}&limit={Limit}");
        }
    }
}
