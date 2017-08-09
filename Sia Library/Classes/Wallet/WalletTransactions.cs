using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
{
    class WalletTransactions: EndPointPostAbstract
    {
        public WalletTransactions()
        {
            Address = "http://localhost:9980/wallet/transactions";
        }

        public WalletTransactions(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/transactions";
        }
    }
}
