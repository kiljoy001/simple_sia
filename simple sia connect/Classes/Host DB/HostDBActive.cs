using simple_sia_connect.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Host_DB
{
    class HostDBActive : EndPointConnectAbstract
    {
        public HostDBActive(string siaAddress, string numhosts)
        {
            if (!String.IsNullOrEmpty(numhosts))
            {
                Address = $"{siaAddress}";
            }
            else
            {
                //number validator makes sures that the input is actually a postive number
                try
                {
                    string numberValidatior = uint.Parse(numhosts).ToString();
                    Address = $"{siaAddress}?={numberValidatior}";
                }
                catch { throw new ArgumentException(); }                
                
            }
        }

        public HostDBActive()
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
