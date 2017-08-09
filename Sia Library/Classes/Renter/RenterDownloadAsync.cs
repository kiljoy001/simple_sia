using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Renter
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
    }
}
