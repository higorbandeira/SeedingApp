using System;
using System.Collections.Generic;
using System.Text;

namespace AppSample.ViewModels
{
    class LoginPageViewModel
    {
    }

    public class LoginResponse
    {
        public LoginResponse(string token, string userName)
        {
            Token = token;
            UserName = userName;
        }

        public string Token { get; private set; }

        public string UserName { get; private set; }
    }
}
