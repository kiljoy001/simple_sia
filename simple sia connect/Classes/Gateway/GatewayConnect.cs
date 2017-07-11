using Newtonsoft.Json;
using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Gateway
{
    class GatewayConnect:EndPointPostAbstract
    {
        public override string Address { set => Address = ""; get => Address; }
        private string _netaddress { get; set; }
        public GatewayConnect(string netaddress, string siaAddress)
        {
            Address = $"http://{siaAddress}/gateway/connect/:";
            //regex matches for 1 to 3 digits with period seperator, will throw exception if ip address is not valid 
            Match ip = Regex.Match(netaddress, @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");
            if (ip.Success)
            {
                _netaddress = netaddress;
            }
            else throw new ArgumentException();
        }
        public async Task Post(HttpClient client)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            if (this._netaddress != null)
            {
                var result = client.PostAsync(Address, new StringContent(_netaddress, Encoding.UTF8, "application/json"));
                HttpResponseMessage response = await result;
                string returncode = response.StatusCode.ToString();
                //error or success reporting
                if (response.IsSuccessStatusCode) { Console.WriteLine($"Success - Status Code: {returncode}\n"); }
                else { Console.WriteLine($"Failure - Status Code: {returncode}\n"); }
            }
           
        }
    }
}
