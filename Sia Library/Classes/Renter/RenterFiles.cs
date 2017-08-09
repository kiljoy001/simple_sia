using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Renter
{
    class RenterFiles : EndPointConnectAbstract
    {
        public RenterFiles(string siaAddress)
        {
            Address = $"http://{siaAddress}/renter";
        }

        public RenterFiles()
        {
            Address = "http://localhost:9980/renter";
        }

    }
}
