﻿using simple_sia_library.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Host
{
    class GetHost : EndPointConnectAbstract
    {
        public GetHost(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/host";
        }

        public GetHost()
        {
            Address = "http://localhost:9980/host";
        }

    }
}
