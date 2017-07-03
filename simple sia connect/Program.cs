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
            var test = new DaemonConstants();
            test.Connect(test.Agent, test.Address).Wait();
        }
    }
}