﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using simple_sia_connect.Classes.Daemon;
using simple_sia_connect.Classes.Consensus;
using simple_sia_connect.Classes.JSON_Models;
using Newtonsoft.Json;

namespace simple_sia_connect
{
    class Program
    {
        public static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            var test = new DaemonConstants();
            test.Connect(client).Wait();
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            var test2 = new ConsensusStatus();
            test2.Connect(client).Wait();
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            var test3 = new ConsensusValidateTransactionSet();
            
        }
      
    }
}