using simple_sia_library.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Miner
{
    class GetMinerHeader : EndPointConnectAbstract
    {
        public GetMinerHeader(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/miner/header";
        }

        public GetMinerHeader()
        {
            Address = "http://localhost:9980/miner/header";
        }
        
    }
}
