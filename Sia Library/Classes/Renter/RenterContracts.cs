using System;
using System.Collections.Generic;
using System.Text;
using simple_sia_library.Classes.Abstract;
using System.Threading.Tasks;
using System.Net.Http;

namespace simple_sia_library.Classes.Renter
{
    class RenterContracts : EndPointConnectAbstract
    {
        public RenterContracts(string siaAddress)
        {
            Address = $"http://{siaAddress}/renter";
        }

        public RenterContracts()
        {
            Address = "http://localhost:9980/renter";
        }
    }
}
