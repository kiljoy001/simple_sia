using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System;

namespace simple_sia_connect.Classes.Abstract
{
    public abstract class EndPointPostAbstract:IEndPoint
    {
         
        public string Address { set;  get; }
        //Constructors
        public EndPointPostAbstract() { }
        public EndPointPostAbstract(string siaAddress) { Address = $"http://{siaAddress}"; }
        //inject client & object model into method
        public async Task<string> Post(HttpClient client, Object data)
        {
            //This method is not to be used for objects that can be null i.e. no object passed.
            string seralized_object = JsonConvert.SerializeObject(data);
            if(!String.IsNullOrEmpty(seralized_object))
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, seralized_object);
                HttpResponseMessage response = await client.SendAsync(request);
                string returncode = response.RequestMessage.ToString();
                //error or success reporting
                if (response.IsSuccessStatusCode) return $"Success - Response Message: {returncode}\n";
                else return $"Failure - Response Message: {returncode}\n";
            }
            else { throw new NullReferenceException(); }
            
        }
    }
}
