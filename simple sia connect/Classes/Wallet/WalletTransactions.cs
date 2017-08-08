using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
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
