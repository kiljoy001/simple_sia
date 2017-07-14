﻿using simple_sia_connect.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Daemon
{
    class DaemonVersion: EndPointConnectAbstract
    {
        public DaemonVersion(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/daemon/version";
        }

        public DaemonVersion()
        {
            Address = "http://localhost:9980/daemon/version";
        }

        public override async Task Connect(HttpClient client)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
    }
}
