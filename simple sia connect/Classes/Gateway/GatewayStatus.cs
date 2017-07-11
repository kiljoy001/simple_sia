using simple_sia_connect.Classes.Daemon;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Gateway
{
    class GatewayStatus:EndPointConnectAbstract
    {
        public override string Address => "http://localhost:9980/gateway";
        public override string Agent => "Sia-Agent";

        public override async Task Connect(HttpClient client)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
    }
}
