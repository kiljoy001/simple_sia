using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
{
    class WalletChangePassword: EndPointPostAbstract
    {
        public WalletChangePassword()
        {
            Address = "http://localhost:9980/wallet/changepassword";
        }

        public WalletChangePassword(string siaAddress): base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/changepassword";
        }
    }
}
