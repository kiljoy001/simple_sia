using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Abstract
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
        
        public new async Task<string> Connect(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync(Address);
            string response_data = response.RequestMessage.ToString();
            if (response.IsSuccessStatusCode)
            {
                return $"Success - Response Message: {response_data}";
            }
            else
            {
                return $"Failure - Response Message: {response_data}";
            }
        }
    }
}
