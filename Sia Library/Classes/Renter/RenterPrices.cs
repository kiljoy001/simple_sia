﻿using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Renter
{
    class RenterPrices : EndPointConnectAbstract
    {
        public RenterPrices(string siaAddress)
        {
            Address = $"http://{siaAddress}/renter";
        }

        public RenterPrices()
        {
            Address = "http://localhost:9980/renter";
        }

    }
}
