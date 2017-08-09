using simple_sia_library.Classes.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace simple_sia_library.Classes.Host
{
    class HostEstimateScore:EndPointConnectAbstract
    {
        public HostEstimateScore(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/host/estimatescore";
        }

        public HostEstimateScore()
        {
            Address = "http://localhost:9980/host/estimatescore";
        }

    }
}
