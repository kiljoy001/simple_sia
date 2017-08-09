using System;
using System.Net.Http;
using System.Threading.Tasks;
using simple_sia_library.Classes.Abstract;

namespace simple_sia_library.Classes.Gateway
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
        
    }
}
