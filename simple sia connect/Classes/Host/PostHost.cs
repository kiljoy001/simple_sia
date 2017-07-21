using Newtonsoft.Json;
using simple_sia_connect.Classes.Abstract;
using simple_sia_connect.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Host
{
    class PostHost: EndPointPostAbstract
    {
        public PostHost(string siaAddress)
        {
            Address = $"http://{siaAddress}/host";
        }

        public PostHost()
        {
            Address = "http://localhost:9980/host";
        }
        public async Task<string> PostUrl(HttpClient client, Object data, string end_point_address)
        {
            Dictionary<string, string> Conversion = new Dictionary<string, string>();
            PropertyReflector main_object = new PropertyReflector(data);
            if (main_object.ReturnValue.Count > 0)
            {
                foreach (KeyValuePair<string, object> pair in main_object.ReturnValue)
                {
                    PropertyReflector sub_object = new PropertyReflector(pair.Value);
                    foreach(KeyValuePair<string, object> sub_pair in sub_object.ReturnValue)
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
