using simple_sia_connect.Classes.Abstract;
using simple_sia_connect.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Host
{
    class HostAnnounce : EndPointPostAbstract
    {
        string _netAddress { get; set; }

        public HostAnnounce(string address = null)
        {
            _netAddress = address;

            if (_netAddress == null)
            {
                Address = "https://localhost:9880/host/announce";
            }

            else
            {
                NetAddressValidator validate = new NetAddressValidator();
                if (validate.Validate(address))
                {
                    Address = $"http://localhost:9980/host/announce/{_netAddress}";
                }
            }
        }

        public HostAnnounce(string siaAddress, string address = null) :base(siaAddress)
        {
            _netAddress = address;

            if (_netAddress == null)
            {
                Address = $"https://{siaAddress}/host/announce";
            }

            else
            {
                NetAddressValidator validate = new NetAddressValidator();
                if (validate.Validate(address))
                {
                    Address = $"http://{siaAddress}/host/announce/{_netAddress}";
                }
            }
        }

        public async Task Post(HttpClient client)
        { 
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"/gateway/connect/{_netAddress}");
                HttpResponseMessage response = await client.SendAsync(request);
                string returncode = response.RequestMessage.ToString();
                //error or success reporting
                if (response.IsSuccessStatusCode) { Console.WriteLine($"Success - Response Message: {returncode}\n"); }
                else { Console.WriteLine($"Failure - Response Message: {returncode}\n"); }
        }
    }
}
