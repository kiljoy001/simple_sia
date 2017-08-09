using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Miner
{
    class PostMinerHeader : EndPointPostAbstract
    {
        public PostMinerHeader(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/miner/header";
        }

        public PostMinerHeader()
        {
            Address = "http://localhost:9980/miner/header";
        }
    }
}
