﻿using simple_sia_connect.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Miner
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

        public new async Task<string> Connect(HttpClient client)
        {
            //TODO add a json response handler to relay if command was successful or not.
             
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            return msg;
        }
    }
}
