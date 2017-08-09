using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
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
