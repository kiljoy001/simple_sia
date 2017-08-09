using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using simple_sia_library.Classes.Abstract;

namespace simple_sia_library.Classes.Renter
{
    class RenterStatus : EndPointConnectAbstract
    {
        public RenterStatus(string siaAddress)
        {
            Address = $"http://{siaAddress}/renter";
        }

        public RenterStatus()
        {
            Address = "http://localhost:9980/renter";
        }

    }
}
