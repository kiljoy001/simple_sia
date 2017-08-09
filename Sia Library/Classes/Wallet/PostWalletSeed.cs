﻿using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Wallet
{
    class PostWalletSeed: EndPointPostAbstract
    {
        public PostWalletSeed()
        {
            Address = "http://localhost:9980/wallet/seed";
        }

        public PostWalletSeed(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/wallet/seed";
        }
    }
}
