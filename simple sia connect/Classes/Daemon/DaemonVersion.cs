using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Daemon
{
    class DaemonVersion: EndPointConnectAbstract
    {
        public override string Agent => "Sia-Agent";
        public override string Address => "//localhost:9980/daemon/version";
        public override async Task Connect(HttpClient client)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
    }
}
