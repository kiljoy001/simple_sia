using Newtonsoft.Json;
using simple_sia_connect.Classes.Abstract;
using simple_sia_connect.Classes.Helper;
using simple_sia_connect.Classes.JSON_Models;
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

        public async Task<string> PostUrl(HttpClient client, OptionalHostPostParameters data, string end_point_address)
        {
            //Dictionary is the storage for the optional host post parameters that will be used for urlencode
            Dictionary<string, string> Conversion = new Dictionary<string, string>();
            //get the main object properties and sub objects
            PropertyReflector main_object = new PropertyReflector(data);
            //quick check to make sure there are properties to inspect further. Throws a invalid operation exception if it fails
            if (main_object.ReturnValue.Count > 0)
            {
                foreach (KeyValuePair<string, object> pair in main_object.ReturnValue)
                {
                    //reflecting the sub object to get their properties
                    PropertyReflector sub_object = new PropertyReflector(pair.Value);
                    foreach(KeyValuePair<string, object> sub_pair in sub_object.ReturnValue)
                    {
                        //checking to see if each each property has a more complex class, if it matches then inspect the complex sub object and then adds it to the dictionary collection as a parameter - this is probably very buggy.
                        switch (sub_pair.Key)
                        {
                            case "Collateral":
                                PropertyReflector collateral_reflect = new PropertyReflector(sub_pair.Value);
                                AddToDict(collateral_reflect, Conversion);
                                continue;

                            case "MinDownloadBandwidthPrice":
                                PropertyReflector mindown_reflect = new PropertyReflector(sub_pair.Value);
                                AddToDict(mindown_reflect, Conversion);
                                continue;

                            case "MinStoragePrice":
                                PropertyReflector minstor_reflect = new PropertyReflector(sub_pair.Value);
                                AddToDict(minstor_reflect, Conversion);
                                continue;

                            case "MinUploadBandwidthPrice":
                                PropertyReflector minupload_reflect = new PropertyReflector(sub_pair.Value);
                                AddToDict(minupload_reflect, Conversion);
                                continue;

                            case "Block":
                                PropertyReflector block_reflect = new PropertyReflector(sub_pair.Value);
                                AddToDict(block_reflect, Conversion);
                                continue;

                            default:
                                if(sub_pair.Value != null) { Conversion.Add(sub_pair.Key, sub_pair.Value.ToString()); }
                                continue;
                        }
                        
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
        private void AddToDict(PropertyReflector reflector, Dictionary<string, string> Conversion)
        {
            foreach(KeyValuePair<string, object> pair in reflector.ReturnValue)
            {
                if (pair.Value == null) { continue; }
                else { Conversion.Add(pair.Key, pair.Value.ToString()); }
            }
        }

    }
}
