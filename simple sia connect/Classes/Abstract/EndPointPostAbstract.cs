using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System;
using System.Text;

namespace simple_sia_connect.Classes.Abstract
{
    public abstract class EndPointPostAbstract:IEndPoint
    {
        public abstract string Agent { get; }
        public abstract string Address { get; }
        //inject client & object model into method
        public async Task Post(HttpClient client, string data)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            var result = client.PostAsync(Address, new StringContent(data, Encoding.UTF8, "application/json"));
            HttpResponseMessage response = await result;
            string returncode = response.StatusCode.ToString();

            if (response.IsSuccessStatusCode) { Console.WriteLine($"Success - Status Code: {returncode}\n"); }
            else { Console.WriteLine($"Failure - Status Code: {returncode}\n"); }
        }
    }
}
