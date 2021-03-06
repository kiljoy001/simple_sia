﻿using simple_sia_library.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Daemon
{
    public class DaemonConstants: EndPointConnectAbstract
    {
        public DaemonConstants(string siaAddress)
        {
            Address = $"http://{siaAddress}/daemon/constants";
        }

        public DaemonConstants()
        {
            Address = "http://localhost:9980/daemon/constants";
        }

        
    }
}