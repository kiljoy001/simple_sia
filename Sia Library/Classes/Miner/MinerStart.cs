using simple_sia_library.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Miner
{
    class MinerStart : EndPointConnectAbstract
    {
        public MinerStart(string siaAddress) : base(siaAddress)
        {
            Address =$"http://{siaAddress}/miner/start";
        }

        public MinerStart()
        {
            Address = "http://localhost:9980/miner/start";
        }

    }
}
