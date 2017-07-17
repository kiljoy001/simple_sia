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
         
        public string Address { set;  get; }
        //Constructors
        public EndPointPostAbstract() { }
        public EndPointPostAbstract(string siaAddress) { Address = $"http://{siaAddress}"; }
        //inject client & object model into method
        public async Task Post(HttpClient client, Object data)
        {
            var result = client.PostAsync(Address, new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json"));
            HttpResponseMessage response = await result;
            //TODO this code does not return the actuall message - it appears to be a json object
            string returncode = response.StatusCode.ToString();

            if (response.IsSuccessStatusCode) { Console.WriteLine($"Success - Response Message: {returncode}\n"); }
            else { Console.WriteLine($"Failure - Response Message: {returncode}\n"); }
        }
    }
}
