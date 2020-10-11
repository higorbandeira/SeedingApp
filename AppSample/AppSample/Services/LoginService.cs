using AppSample.Models;
using AppSample.ViewModels;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppSample.Services
{
    class LoginService
    {
        public string Login(string login, string password)
        {
            var client = new RestClient("http://seedingprecisionapi.azurewebsites.net/api/user/login");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", "{\r\n\t\"UserName\":\"demo@gmail.com\",\r\n\t\"Password\":\"Test1234!\"\r\n}", ParameterType.RequestBody);
            request.AddParameter("application/json", "{\r\n\t\"UserName\":\"" + login + "\",\r\n\t\"" + "Password\":\"" + password + "\"\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                AppSample.App.MinhaString = JsonConvert.DeserializeObject<LoginResponse>(response.Content);

                LoginResponse token = AppSample.App.MinhaString;

                if (!string.IsNullOrEmpty(token.Token))
                {
                    return "Success";
                }
                else
                {
                    return response.Content;
                }
            }
            {
                return response.Content;
            }
        }
    }
}
