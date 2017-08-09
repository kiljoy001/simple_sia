using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
{
    class WalletAddress: EndPointConnectAbstract
    {
        public WalletAddress()
        {
            Address = "http://localhost:9980/wallet/address";
        }

        public WalletAddress(string siaAddress) :base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/address";
        }
    }
}
