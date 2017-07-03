using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Daemon
{
    public class DaemonConstants: IEndPoint
    {
        
        //Members
        public string Agent => "Sia-Agent";

        public string Address => "http://localhost:9980/daemon/constants";
      
        //Constructor is default
        
        
        //Method
        public async Task Connect(string agentName, string agentAddress)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd(agentName);
            var returnValue = client.GetStringAsync(agentAddress);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
        
    }
}