using simple_sia_connect.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Abstract
{
    class DaemonVersion: EndPointConnectAbstract
    {
        //TODO clean this mess up, it will do a stackoverflow.
        public override string Address { set => Address = "http://localhost:9980/daemon/version"; get => Address; }

        public override async Task Connect(HttpClient client)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
    }
}
