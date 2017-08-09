using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
{
    class WalletLock: EndPointPostAbstract
    {
        public WalletLock()
        {
            Address = "http://localhost:9980/wallet/lock";
        }

        public WalletLock(string siaAddress) :base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/lock";
        }
    }
}
