using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
{
    class WalletVerifyAddress: EndPointConnectAbstract
    {
        public WalletVerifyAddress()
        {
            Address = "http://localhost:9980/wallet/verify/address";
        }

        public WalletVerifyAddress(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/verify/address";
        }
    }
}
