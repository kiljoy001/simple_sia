using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Renter
{
    class RenterUpload : EndPointPostAbstract
    {
        public RenterUpload(string path)
        {
            Address = $"http://localhost:9980/renter/upload/{path}";
        }

        public RenterUpload(string siaAdderess, string path)
        {
            Address = $"http://{siaAdderess}/renter/upload/{path}";
        }
    }
}
