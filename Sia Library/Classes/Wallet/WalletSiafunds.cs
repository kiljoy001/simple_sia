using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
{
    class WalletSiafunds : EndPointPostAbstract
    {
       public WalletSiafunds()
        {
            Address = "http://localhost:9980/wallet/siafunds";
        }

        public WalletSiafunds(string siaAddress) :base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/siafunds";
        }
    }
}
