﻿using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Wallet
{
    class WalletSiagkey : EndPointPostAbstract
    {
        public WalletSiagkey()
        {
            Address = "http://localhost:9980/wallet/siagkey";
        }

        public WalletSiagkey(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/siagkey";
        }
    }
}
