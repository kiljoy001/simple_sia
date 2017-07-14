using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Abstract
{
    class DaemonStop: EndPointConnectAbstract
    {
        public DaemonStop(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/daemon/stop";
        }

        public DaemonStop()
        {
            Address = "http://localhost:9980/daemon/stop";
        }
        
        public override async Task Connect(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync(Address);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Success - Status Code: {response.Content.ToString()}");
            }
            else
            {
                Console.WriteLine($"Failure - Status Code: {response.StatusCode.ToString()}");
            }
        }
    }
}
