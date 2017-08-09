using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using simple_sia_library.Classes.Abstract;

namespace simple_sia_library.Classes.Host
{
    class HostStorage : EndPointConnectAbstract
    {
        public HostStorage(string siaAddress)
        {
            Address = $"http://{siaAddress}/host/storage";
        }

        public HostStorage()
        {
            Address = "http://localhost:9980/host/storage";
        }

    }
}
