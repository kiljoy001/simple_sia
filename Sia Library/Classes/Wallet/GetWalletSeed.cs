using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
{
    class GetWalletSeed: EndPointConnectAbstract
    {
        public GetWalletSeed()
        {
           Address = "http://localhost:9980/wallet/seed";
        }
        
        public GetWalletSeed(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/seed";
        }
    }
}
