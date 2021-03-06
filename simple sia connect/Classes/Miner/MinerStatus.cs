﻿using simple_sia_connect.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Miner
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

        public new async Task<string> Connect(HttpClient client)
        {
             
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            return msg;
        }
    }
}
