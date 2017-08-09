using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Renter
{
    class RenterUpdate:EndPointPostAbstract
    {
        public RenterUpdate()
        {
            Address = "http://localhost:9980/renter";
        }

        public RenterUpdate(string siaAddress) : base(siaAddress)
        {
            siaAddress = $"http://{siaAddress}/renter";
        }
    }
}
