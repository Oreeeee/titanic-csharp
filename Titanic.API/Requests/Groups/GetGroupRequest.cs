using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetGroupRequest : APIRequest<GroupModel>
    {
        public int GroupId { get; set; }

        public GetGroupRequest(int groupId)
        {
            GroupId = groupId;
        }

        protected override GroupModel Execute(TitanicAPI api)
        {
            return api.Get<GroupModel>($"/groups/{GroupId}");
        }
    }
}
