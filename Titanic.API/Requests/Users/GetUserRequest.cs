using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetUserRequest : APIRequest<UserModel>
    {
        public int UserId { get; set; }

        public GetUserRequest(int userId)
        {
            UserId = userId;
        }

        protected override UserModel Execute(TitanicAPI api)
        {
            return api.Get<UserModel>($"/users/{UserId}");
        }
    }
}
