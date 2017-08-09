using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
{
    class Wallet033x: EndPointPostAbstract
    {
        public Wallet033x()
        {
            Address = $"http://localhost:9980/wallet/033x";
        }

        public Wallet033x(string siaAddress): base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/033x";
        }
    }
}
