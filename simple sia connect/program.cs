using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using simple_sia_connect.Classes.Abstract;
using simple_sia_connect.Classes.Consensus;
using simple_sia_connect.Classes.JSON_Models;
using simple_sia_connect.Classes.Gateway;
using simple_sia_connect.Classes.Daemon;
using Newtonsoft.Json;

namespace simple_sia_connect
{
    class Program
    {
        public static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            //Client base address
            client.BaseAddress = new Uri("http://localhost:9980");
            var test = new DaemonConstants();
            //Adds the user agent "Sia-Agent" which is used for connecting to the 
            client.DefaultRequestHeaders.UserAgent.ParseAdd(test.Agent);
            test.Connect(client).Wait();
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            var test2 = new ConsensusStatus();
            test2.Connect(client).Wait();
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            // test later var test3 = new ConsensusValidateTransactionSet();
            var test4 = new GatewayStatus();
            test4.Connect(client).Wait();
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            var test5 = new GatewayConnect("188.242.52.10:9981", "localhost:9980");
            test5.Post(client).Wait();
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            var test6 = new DaemonConstants("localhost:9980");
            test6.Connect(client).Wait();
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
        }
      
    }
}