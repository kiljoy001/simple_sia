using simple_sia_library.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Host_DB
{
    class HostDBActive : EndPointConnectAbstract
    {
        public HostDBActive(string siaAddress, string numhosts)
        {
            if (!String.IsNullOrEmpty(numhosts))
            {
                Address = $"http://{siaAddress}/hostdb/active";
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
            Address = "http://localhost:9980/hostdb/active";
        }
    }
}
