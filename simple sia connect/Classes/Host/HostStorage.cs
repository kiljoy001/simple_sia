﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using simple_sia_connect.Classes.Abstract;

namespace simple_sia_connect.Classes.Host
{
    class HostStorage : EndPointConnectAbstract
    {
        public HostStorage(string siaAddress)
        {
        }

        public HostStorage()
        {
            Address = "http://localhost:9980/estimatescore";
        }

        public override string Address { get; set; }

        public override async Task Connect(HttpClient client)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
    }
}
