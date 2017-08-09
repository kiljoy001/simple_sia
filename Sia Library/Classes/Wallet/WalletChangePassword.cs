using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
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
