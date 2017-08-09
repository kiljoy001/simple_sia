using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
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
