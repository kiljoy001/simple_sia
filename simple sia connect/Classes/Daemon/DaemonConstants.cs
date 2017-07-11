using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Daemon
{
    public class DaemonConstants: EndPointConnectAbstract
    {
        public DaemonConstants(string siaAddress) : base(siaAddress)
        {
        }

        public DaemonConstants()
        {
            Address = "http://localhost:9980/daemon/constants";
        }
        public override string Address { set; get; }

        public override async Task Connect(HttpClient client)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
        
    }
}