using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
{
    class WalletAddresses: EndPointConnectAbstract
    {
        public WalletAddresses()
        {
            Address = "http://localhost:9980/wallet/addresses";
        }

        public WalletAddresses(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/addresses";
        }
    }
}
