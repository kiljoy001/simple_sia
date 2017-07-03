using System;
using simple_sia_connect.Interfaces;

namespace simple_sia_connect
{
    interface IEndPointFactory
    {
        IEndPoint setPoint(string Agent, string Address);
        IDisposable Dispose();
    }
}

