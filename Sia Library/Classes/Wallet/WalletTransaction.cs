using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
{
    class WalletTransaction: EndPointConnectAbstract
    {
        public WalletTransaction()
        {
            Address = "http://localhost:9980/wallet/transaction";
        }

        public WalletTransaction(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/transaction";
        }
    }
}
