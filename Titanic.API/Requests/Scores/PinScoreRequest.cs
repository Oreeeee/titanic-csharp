namespace Titanic.API.Requests
{
    public class PinScoreRequest : APIRequest<object>
    {
        public long ScoreId { get; set; }

        public PinScoreRequest(long scoreId)
        {
            ScoreId = scoreId;
        }

        protected override object Execute(TitanicAPI api)
        {
            return api.Post<object>($"/scores/{ScoreId}/pin", null);
        }
    }
}
