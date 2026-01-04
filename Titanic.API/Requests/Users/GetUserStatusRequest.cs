using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetUserStatusRequest : APIRequest<UserStatusModel>
    {
        public int UserId { get; set; }

        public GetUserStatusRequest(int userId)
        {
            UserId = userId;
        }

        protected override UserStatusModel Execute(TitanicAPI api)
        {
            return api.Get<UserStatusModel>($"/users/{UserId}/status");
        }
    }
}
