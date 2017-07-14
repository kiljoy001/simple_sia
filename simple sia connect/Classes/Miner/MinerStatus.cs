using simple_sia_connect.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Miner
{
    class MinerStatus : EndPointConnectAbstract
    {
        public MinerStatus(string siaAddress) : base(siaAddress)
        {
            Address=$"http://{siaAddress}/miner";
        }

        public MinerStatus()
        {
            Address = "http://localhost:9980/miner";
        }

        public override async Task Connect(HttpClient client)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
    }
}
