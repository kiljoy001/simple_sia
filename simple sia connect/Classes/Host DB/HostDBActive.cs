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
                Address = $"http://{siaAddress}";
            }
            else
            {
                //number validator makes sures that the input is actually a postive number
                try
                {
                    string numberValidatior = uint.Parse(numhosts).ToString();
                    Address = $"http://{siaAddress}?={numberValidatior}";
                }
                catch { throw new ArgumentException(); }                
                
            }
        }

        public HostDBActive()
        {
            Address = "http://localhost:9980/estimatescore";
        }

        public override async Task<string> Connect(HttpClient client)
        {
             
            var returnValue = client.GetStringAsync(Address);
            var msg = await returnValue;
            return msg;
        }
    }
}
