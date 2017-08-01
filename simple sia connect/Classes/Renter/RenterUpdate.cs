using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Renter
{
    class RenterUpdate:EndPointPostAbstract
    {
        public RenterUpdate()
        {
            Address = $"http://localhost:9980/renter";
        }

        public RenterUpdate(string siaAddress) : base(siaAddress)
        {
        }
    }
}
