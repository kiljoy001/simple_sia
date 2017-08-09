using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Transaction_Pool
{
    class TpoolRaw : EndPointConnectAbstract
    {
        public TpoolRaw(string id)
        {
            Address = $"http://localhost:9980/tpool/raw/{id}";
        }

        public TpoolRaw(string siaAddress, string id) :base(siaAddress)
        {
            Address = $"http://{siaAddress}/tpool/raw/{id}";
        }
    }
}
