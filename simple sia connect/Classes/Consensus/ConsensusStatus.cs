using System;
using simple_sia_connect.Classes.Abstract;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Consensus
{
    public class ConsensusStatus : EndPointConnectAbstract
    {
        public ConsensusStatus(string siaAddress)
        {
            Address = $"http://{siaAddress}/consensus";
        }

        public ConsensusStatus()
        {
            Address = "http://localhost:9980/consensus";
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
