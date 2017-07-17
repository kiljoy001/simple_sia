using System;
using System.Net.Http;
using System.Threading.Tasks;
using simple_sia_connect.Classes.Abstract;

namespace simple_sia_connect.Classes.Gateway
{
    class GatewayStatus : EndPointConnectAbstract
    {
        public GatewayStatus(string siaAddress) : base(siaAddress)
        {
        }
        public GatewayStatus()
        {
            Address = "http://localhost:9980/gateway";
        }
        public override async Task<string> Connect(HttpClient client)
        {
            // 
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            return msg;
        }
    }
}
