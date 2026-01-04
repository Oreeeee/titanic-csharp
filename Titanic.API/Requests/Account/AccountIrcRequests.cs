using System;
using System.Collections.Generic;
using System.Text;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class GetIrcTokenRequest : APIRequest<IrcTokenModel>
    {
        protected override IrcTokenModel Execute(TitanicAPI api)
        {
            return api.Get<IrcTokenModel>("/account/irc/token");
        }
    }

    public class RegenerateIrcTokenRequest : APIRequest<IrcTokenModel>
    {
        protected override IrcTokenModel Execute(TitanicAPI api)
        {
            return api.Post<IrcTokenModel>("/account/irc/token", null);
        }
    }
}
