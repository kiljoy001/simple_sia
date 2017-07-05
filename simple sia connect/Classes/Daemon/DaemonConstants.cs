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
        public override async Task Connect()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd(this.Agent);
            var returnValue = client.GetStringAsync(this.Address);
            var msg = await returnValue;
            Console.WriteLine(msg);
        }
        
    }
}