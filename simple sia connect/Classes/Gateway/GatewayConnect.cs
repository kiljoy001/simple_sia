using simple_sia_connect.Classes.Abstract;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Gateway
{
    class GatewayConnect:EndPointPostAbstract
    {
        public override string Address { set; get;}
        private string _netaddress { get; set; }
        Match ip;

        GatewayConnect(string netaddress)
        {
            //regex matches for 1 to 3 digits with period seperator, will throw exception if ip address is not valid. Addresses need to have port numbers as well.
            ip = Regex.Match(netaddress, @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])\:\d{1,5}$");
            if (ip.Success)
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
            ip = Regex.Match(netaddress, @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])\:\d{1,5}$");
            if (ip.Success)
            {
                _netaddress = netaddress;
                Address = $"http://{siaAddress}/gateway/connect/{_netaddress}";
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public async Task Post(HttpClient client)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            if (_netaddress != null && Address != null)
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"/gateway/connect/{_netaddress}");
                HttpResponseMessage response = await client.SendAsync(request);
                string returncode = response.StatusCode.ToString();
                //error or success reporting
                if (response.IsSuccessStatusCode) { Console.WriteLine($"Success - Status Code: {returncode}\n"); }
                else { Console.WriteLine($"Failure - Status Code: {returncode}\n"); }
            }
           
        }
    }
}
