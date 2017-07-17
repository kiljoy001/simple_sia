using simple_sia_connect.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Host
{
    class HostEstimateScore:EndPointConnectAbstract
    {
        public HostEstimateScore(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/host/estimatescore";
        }

        public HostEstimateScore()
        {
            Address = "http://localhost:9980/host/estimatescore";
        }

        public override async Task Connect(HttpClient client)
        {
             
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
    }
}
