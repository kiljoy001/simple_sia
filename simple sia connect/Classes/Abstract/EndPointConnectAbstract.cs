/*
This abstract class was created to make http GET connections easy. It implements IEndpoint and IDisposable.
*/

using System;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Daemon
{
    public abstract class EndPointConnectAbstract : IEndPoint
    {
        //Decided to make this abstract since Sia is a realtively young project - in time they may chance the address or agent name. Also allows for customizable address & agent which are allowed in sia settings
        public abstract string Agent { get; }
        public abstract string Address { get; }
        //default constructor does not do anything except create the object
        //Each subclass should always have a connect method
        public abstract Task Connect(HttpClient client);
    }
}