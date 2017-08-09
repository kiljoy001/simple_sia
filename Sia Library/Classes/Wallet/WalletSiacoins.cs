using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
{
    class WalletSiacoins: EndPointPostAbstract
    {
        public WalletSiacoins()
        {
            Address = "http://localhost:9980/wallet/siacoins";
        }

        public WalletSiacoins(string siaAddress): base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/siacoins";
        }
    }
}
