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
        }

        public HostEstimateScore()
        {
            Address = "http://localhost:9980/estimatescore";
        }

        public override string Address { get; set; }

        public override async Task Connect(HttpClient client)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
    }
}
