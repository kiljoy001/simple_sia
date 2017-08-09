using simple_sia_library.Classes.Abstract;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Gateway
{
    class GatewayConnect:EndPointPostAbstract
    {

        private string _netaddress { get; set; }
        private string filter = @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])\:\d{1,5}$";

        GatewayConnect(string netaddress)
        {
            //regex matches for 1 to 3 digits with period seperator, will throw exception if ip address is not valid. Addresses need to have port numbers as well.
            if (this.IsValidNetAddress(netaddress))
            {
                Address = $"http://localhost:9980/gateway/connect/{netaddress}";
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public GatewayConnect(string netaddress, string siaAddress)
        {
            Address = null;
            //regex matches for 1 to 3 digits with period seperator, will throw exception if ip address is not valid  Addresses need to have port numbers as well.
            if (this.IsValidNetAddress(netaddress))
            {
                _netaddress = netaddress;
                Address = $"http://{siaAddress}/gateway/connect/{_netaddress}";
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private bool IsValidNetAddress(string input)
        {
            return Regex.Match(input, filter).Success;
        }

        public async Task Post(HttpClient client)
        {
            // 
            if (_netaddress != null && Address != null)
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"/gateway/connect/{_netaddress}");
                HttpResponseMessage response = await client.SendAsync(request);
                string returncode = response.RequestMessage.ToString();
                //error or success reporting
                if (response.IsSuccessStatusCode) { Console.WriteLine($"Success - Response Message: {returncode}\n"); }
                else { Console.WriteLine($"Failure - Response Message: {returncode}\n"); }
            }
           
        }
    }
}
