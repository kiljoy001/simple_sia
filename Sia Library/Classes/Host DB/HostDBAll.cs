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
            Address = $"http://{siaAddress}/hostdb/all";
        }

        public HostDBAll()
        {
            Address = "http://localhost:9980/hostdb/all";
        }
    }
}
