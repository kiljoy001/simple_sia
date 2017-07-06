﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Daemon
{
    public class DaemonConstants: EndPointConnectAbstract
    {
        
        //Members
        public override string Agent => "Sia-Agent";

        public override string Address => "http://localhost:9980/daemon/constants";
      
        //Constructor is default
        
        
        //Method
        public override async Task Connect(HttpClient client)
        {
            client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
        
    }
}