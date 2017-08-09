using simple_sia_library.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Miner
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
    }
}
