using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
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
