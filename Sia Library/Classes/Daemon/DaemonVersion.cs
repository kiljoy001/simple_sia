using simple_sia_library.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Daemon
{
    class DaemonVersion: EndPointConnectAbstract
    {
        public DaemonVersion(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/daemon/version";
        }

        public DaemonVersion()
        {
            Address = "http://localhost:9980/daemon/version";
        }

    }
}
