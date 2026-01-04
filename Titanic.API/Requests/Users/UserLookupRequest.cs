using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class UserLookupRequest : APIRequest<UserModel>
    {
        public string Input { get; set; }

        public UserLookupRequest(string input)
        {
            Input = input;
        }

        protected override UserModel Execute(TitanicAPI api)
        {
            return api.Get<UserModel>($"/users/lookup/{Input}");
        }
    }
}
