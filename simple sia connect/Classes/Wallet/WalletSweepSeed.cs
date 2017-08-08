using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
{
    class WalletSweepSeed: EndPointPostAbstract
    {
        public WalletSweepSeed()
        {
            Address = "http://localhost:9980/wallet/sweep/seed";
        }

        public WalletSweepSeed(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/sweep/seed";
        }

    }
}
