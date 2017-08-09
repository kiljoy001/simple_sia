using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Renter
{
    class RenterRename : EndPointPostAbstract
    {
        public RenterRename(string path)
        {
            Address = $"http://localhost:9980/renter/rename/{path}";
        }

        public RenterRename(string siaAddress, string path)
        {
            Address = $"http://{siaAddress}/renter/rename/{path}";
        }
    }
}
