using System;
using System.Collections.Generic;
using System.Text;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class AccountProfileRequest : APIRequest<UserModel>
    {
        protected override UserModel Execute(TitanicAPI api)
        {
            return api.Get<UserModel>("/account/profile");
        }
    }
}
