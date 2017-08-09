using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using simple_sia_library.Classes.Helper;

namespace simple_sia_library.Classes.Abstract
{
    public abstract class EndPointPostAbstract : IEndPoint
    {

        public string Address { set; get; }
        //Constructors
        public EndPointPostAbstract() { }
        public EndPointPostAbstract(string siaAddress) { Address = $"http://{siaAddress}"; }
        //inject client & object model into method
        public async Task<string> Post(HttpClient client, Object data, string end_point_address)
        {
            //This method is not to be used for objects that can be null i.e. no object passed. Also by default it sends a string value that is encoded as json
            string seralized_object = JsonConvert.SerializeObject(data);
            if (!String.IsNullOrEmpty(seralized_object))
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, end_point_address);
                request.Content = new StringContent(seralized_object);
                HttpResponseMessage response = await client.SendAsync(request);
                string returncode = response.RequestMessage.ToString();
                //error or success reporting
                if (response.IsSuccessStatusCode) return $"Success - Response Message: {returncode}\n";
                else return $"Failure - Response Message: {returncode}\n";
            }
            else { throw new NullReferenceException(); }

        }

        public async Task<string> PostUrl(HttpClient client, Object data, string end_point_address)
        {
            //Declare a string, string dictionary for FormUrlEnocdedContent
            Dictionary<string, string> Conversion = new Dictionary<string, string>();
            //Get a dictionary from the reflector (string, object)
            PropertyReflector main_object = new PropertyReflector(data);
            //If the object has no key value pairs it will throw an error
            if (main_object.ReturnValue.Count > 0)
            {
                foreach (KeyValuePair<string, object> pair in main_object.ReturnValue)
                {
                    //recursively check properties to see if they also have properties. This most likely buggy
                    PropertyReflector sub_object = new PropertyReflector(pair.Value);
                    foreach (KeyValuePair<string, object> sub_pair in sub_object.ReturnValue)
                    {
                        Conversion.Add(sub_pair.Key, sub_pair.Value.ToString());
                    }
                }
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, end_point_address)
                {
                    Content = new FormUrlEncodedContent(Conversion)
                };
                HttpResponseMessage response = await client.SendAsync(request);
                string returncode = response.RequestMessage.ToString();
                //error or success reporting
                if (response.IsSuccessStatusCode) return $"Success - Response Message: {returncode}\n";
                else return $"Failure - Response Message: {returncode}\n";
            }
            else { throw new InvalidOperationException(); }
        }
    }
}
