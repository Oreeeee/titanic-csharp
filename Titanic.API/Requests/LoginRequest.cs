using System;
using System.Collections.Generic;
using System.Text;
using Titanic.API.Models;

namespace Titanic.API.Requests
{
    public class LoginRequest : APIRequest<TokenModel>
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }

        protected override TokenModel Execute(TitanicAPI api)
        {
            TokenModel response = api.Post<TokenModel>("/account/login", null, new Dictionary<string, string>
            {
                { "Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Username}:{Password}"))}" }
            });
            api.Token = response;
            api.Token.ExpiresAt = DateTime.UtcNow.AddSeconds(api.Token.ExpiresIn).ToLocalTime();
            return response;
        }
    }
}
