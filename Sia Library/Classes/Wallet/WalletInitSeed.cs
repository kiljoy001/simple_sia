using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
{
    class WalletInitSeed: EndPointPostAbstract
    {
        public WalletInitSeed()
        {
            Address = "http://localhost:9980/wallet/init/seed";
        }

        public WalletInitSeed(string siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/init/seed";
        }
    }
}
