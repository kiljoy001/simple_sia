using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
{
    class WalletInit: EndPointPostAbstract
    {
        public WalletInit()
        {
            Address = "http://localhost:9980/wallet/init";
        }

        public WalletInit(string siaAddress) :base(siaAddress)
        {
            Address =$"http://{siaAddress}/wallet/init";
        }
    }
}
