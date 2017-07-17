using simple_sia_connect.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Host
{
    class GetHost : EndPointConnectAbstract
    {
        public GetHost(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/host";
        }

        public GetHost()
        {
            Address = "http://localhost:9980/host";
        }

        public override async Task Connect(HttpClient client)
        {
             
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
    }
}
