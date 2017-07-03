using System;
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
        public override async Task Connect(string agentName, string agentAddress)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd(agentName);
            var returnValue = client.GetStringAsync(agentAddress);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
        
    }
}