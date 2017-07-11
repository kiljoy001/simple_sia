using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Daemon
{
    class DaemonStop: EndPointConnectAbstract
    {
        public override string Address { set => Address = "http://localhost:9980/daemon/stop"; get => Address; }

        public override async Task Connect(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync(Address);
            if (response.IsSuccessStatusCode) { Console.WriteLine($"Success - Status Code: {response.StatusCode.ToString()}"); }
            else { Console.WriteLine($"Failure - Status Code: {response.StatusCode.ToString()}"); }
        }
    }
}
