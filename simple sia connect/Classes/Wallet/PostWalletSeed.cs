using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
{
    class PostWalletSeed: EndPointPostAbstract
    {
        public PostWalletSeed()
        {
            Address = "http://localhost:9980/wallet/seed";
        }

        public PostWalletSeed(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/seed";
        }
    }
}
