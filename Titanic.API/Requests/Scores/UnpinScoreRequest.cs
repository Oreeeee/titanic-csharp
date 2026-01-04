namespace Titanic.API.Requests
{
    public class UnpinScoreRequest : APIRequest<object>
    {
        public long ScoreId { get; set; }

        public UnpinScoreRequest(long scoreId)
        {
            ScoreId = scoreId;
        }

        protected override object Execute(TitanicAPI api)
        {
            return api.Delete<object>($"/scores/{ScoreId}/pin");
        }
    }
}
