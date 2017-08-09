using simple_sia_connect.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Miner
{
    class MinerStop : EndPointConnectAbstract
    {
        public MinerStop(string siaAddress) : base(siaAddress)
        {
            Address=$"http://{siaAddress}/miner/stop";
        }

        public MinerStop()
        {
            Address = "http://localhost:9980/miner/stop";
        }

    }
}
