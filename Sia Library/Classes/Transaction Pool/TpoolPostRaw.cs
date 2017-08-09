using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Transaction_Pool
{
    class TpoolPostRaw : EndPointPostAbstract
    {
        public TpoolPostRaw() 
        {
            Address = $"http://localhost:9980/tpool/raw/";
        }

        public TpoolPostRaw(string siaAddress) :base(siaAddress)
        {
            Address = $"http://{siaAddress}/tpool/raw/";
        }
    }
}
