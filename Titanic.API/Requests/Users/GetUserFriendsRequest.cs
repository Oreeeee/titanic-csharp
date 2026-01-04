using System.Collections.Generic;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetUserFriendsRequest : APIRequest<List<UserModelCompact>>
    {
        public int UserId { get; set; }

        public GetUserFriendsRequest(int userId)
        {
            UserId = userId;
        }

        protected override List<UserModelCompact> Execute(TitanicAPI api)
        {
            return api.Get<List<UserModelCompact>>($"/users/{UserId}/friends");
        }
    }
}
