using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
{
    class WalletStatus: EndPointConnectAbstract
    {
        public WalletStatus()
        {
            Address = $"http://localhost:9980/wallet";
        }

        public WalletStatus(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet";
        }
    }
}
