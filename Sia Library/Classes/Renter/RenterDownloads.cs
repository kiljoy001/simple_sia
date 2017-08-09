using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Renter
{
    class RenterDownloads : EndPointConnectAbstract
    {
        public RenterDownloads(string siaAddress)
        {
            Address = $"http://{siaAddress}/renter";
        }

        public RenterDownloads()
        {
            Address = "http://localhost:9980/renter";
        }
    }
}
