using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
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
