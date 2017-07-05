using System;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using simple_sia_connect.Classes.Daemon;

namespace simple_sia_connect
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var test = new DaemonConstants())
            {
                test.Connect().Wait();
            }
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            using (var test2 = new ConsensusStatus())
            {
                test2.Connect().Wait();
            }
            
        }
    }
}