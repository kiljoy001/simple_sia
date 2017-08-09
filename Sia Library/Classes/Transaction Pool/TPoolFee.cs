using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Transaction_Pool
{
    class TPoolFee : EndPointConnectAbstract
    {
        public TPoolFee()
        {
            Address = $"http://localhost:9980/tpool/fee";
        }

        public TPoolFee(string siaAddress) : base (siaAddress)
        {
            Address = $"http://{siaAddress}/tpool/fee";
        }


    }
}
