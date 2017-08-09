using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Renter
{
    class RenterDelete : EndPointPostAbstract
    {
        public RenterDelete(string path)
        {
            Address = $"http://localhost:9880/renter/delete/{path}";
        }

        public RenterDelete(string siaAddress, string path)
        {
            Address = $"http://{siaAddress}/renter/delete/{path}";
        }
    }
}
