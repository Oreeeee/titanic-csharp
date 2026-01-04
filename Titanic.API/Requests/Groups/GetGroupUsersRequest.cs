using System.Collections.Generic;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetGroupUsersRequest : APIRequest<List<UserModelCompact>>
    {
        public int GroupId { get; set; }

        public GetGroupUsersRequest(int groupId)
        {
            GroupId = groupId;
        }

        protected override List<UserModelCompact> Execute(TitanicAPI api)
        {
            return api.Get<List<UserModelCompact>>($"/groups/{GroupId}/users");
        }
    }
}
