using AppSample.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppSample.Services
{
    class FarmStatusService
    {
        public List<MyArray> GetAtualStatus()
        {
            var client = new RestClient("http://143.107.145.24:1026/v2/entities");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("fiware-service", "helixiot");
            request.AddHeader("fiware-servicepath", "/");
            request.AddHeader("Authorization", "Basic YWRtaW46QGFkbWluOQ==");
            IRestResponse response = client.Execute(request);
            List<MyArray> myDeserializedClass = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MyArray>>(response.Content);
            return myDeserializedClass;
        }
    }
}
