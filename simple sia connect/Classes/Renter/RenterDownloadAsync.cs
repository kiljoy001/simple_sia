using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Renter
{
    class RenterDownloadAsync :EndPointConnectAbstract
    {
        public RenterDownloadAsync(string siaAddress, string path)
        {
            Address = $"http://{siaAddress}/renter/downloadasync/{path}";
        }

        public RenterDownloadAsync(string path)
        {
            Address 
                = $"http://localhost:9980/renter/downloadasync/{path}";
        }

        public override async Task<string> Connect(HttpClient client)
        {
            var returnValue = client.GetStringAsync(Address);
            string msg = await returnValue;
            return msg;
        }
    }
}
