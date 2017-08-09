using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
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
