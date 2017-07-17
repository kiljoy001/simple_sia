using simple_sia_connect.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Host_DB
{
    class HostDBPubkey : EndPointConnectAbstract
    {
        //pubkey needed to get relevant data from siad
        public HostDBPubkey(string siaAddress, string pubkey) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/hostdb/hosts/ed25519:{pubkey}";
        }

        public HostDBPubkey(string pubkey)
        {
            Address = $"http://localhost:9980/hostdb/hosts/ed25519:{pubkey}";
        }

        public override async Task Connect(HttpClient client)
        {
             
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
    }
}
