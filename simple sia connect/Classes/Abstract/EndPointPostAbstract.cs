using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System;
using System.Text;
using simple_sia_connect.Classes.JSON_Models;

namespace simple_sia_connect.Classes.Abstract
{
    public abstract class EndPointPostAbstract:IEndPoint
    {
        private string _address;
        public string Agent => "Sia-Agent";
        public abstract string Address { set;  get; }
        //Constructors
        public EndPointPostAbstract() { }
        public EndPointPostAbstract(string siaAddress) { _address = $"http://{siaAddress}"; Address = _address; }
        //inject client & object model into method
        public async Task Post(HttpClient client, Object data)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            var result = client.PostAsync(Address, new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json"));
            HttpResponseMessage response = await result;
            string returncode = response.StatusCode.ToString();

            if (response.IsSuccessStatusCode) { Console.WriteLine($"Success - Status Code: {returncode}\n"); }
            else { Console.WriteLine($"Failure - Status Code: {returncode}\n"); }
        }
    }
}
