using System;
using simple_sia_connect.Classes.Daemon;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

public class ConsensusStatus: EndPointConnectAbstract
{
    public override string Address { set => Address = "http://localhost:9980/consensus}"; get => Address; }

    public override async Task Connect(HttpClient client)
    {
        client.DefaultRequestHeaders.UserAgent.ParseAdd(Agent);
        var returnValue = client.GetStringAsync(Address);
        var msg = await returnValue;
        Console.WriteLine(msg);
    }

}
