using simple_sia_connect.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Host_DB
{
    class HostDBAll : EndPointConnectAbstract
    {
        public HostDBAll(string siaAddress) : base(siaAddress)
        {
        }

        public HostDBAll()
        {
            Address = "http://localhost:9980/hostdb/all";
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
