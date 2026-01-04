using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class BenchmarkSubmissionRequest : APIRequest<BenchmarkModel>
    {
        private readonly BenchmarkSubmissionModel submission;

        public BenchmarkSubmissionRequest(BenchmarkSubmissionModel submission)
        {
            this.submission = submission;
        }

        protected override BenchmarkModel Execute(TitanicAPI api)
        {
            return api.Post<BenchmarkModel>("/benchmarks/", submission);
        }
    }
}
