using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
{
    class WalletUnlock : EndPointPostAbstract
    {
        public WalletUnlock()
        {
            Address = "http://localhost:9980/wallet/unlock";
        }

        public WalletUnlock(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/unlock";
        }
    }
}
