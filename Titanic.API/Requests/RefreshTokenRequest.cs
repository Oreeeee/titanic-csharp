using System;
using System.Collections.Generic;
using System.Text;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class RefreshTokenRequest : APIRequest<TokenModel>
    {
        public string RefreshToken { get; set; }

        public RefreshTokenRequest(string refreshToken)
        {
            RefreshToken = refreshToken;
        }

        protected override TokenModel Execute(TitanicAPI api)
        {
            TokenModel response = api.Post<TokenModel>("/account/refresh", null, new Dictionary<string, string>
            {
                { "Authorization", $"Bearer {RefreshToken}" }
            });
            api.Token = response;
            api.Token.ExpiresAt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            api.Token.ExpiresAt = api.Token.ExpiresAt.AddSeconds(api.Token.ExpiresIn).ToLocalTime();
            return response;
        }
    }
}
