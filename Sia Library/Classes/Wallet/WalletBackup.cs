using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
{
    class WalletBackup: EndPointConnectAbstract
    {
        public WalletBackup()
        {
            Address = "http://localhost:9980/wallet/backup";
        }

        public WalletBackup(string siaAddress) :base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/backup";
        }
    }
}
