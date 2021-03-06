﻿using simple_sia_connect.Classes.Abstract;
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

        public new async Task<string> Connect(HttpClient client)
        {
            //TODO add a json response handler to relay if command was successful or not.
             
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            return msg;
        }
    }
}
