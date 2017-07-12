/*
This abstract class was created to make http GET connections easy. It implements IEndpoint.
*/

using System;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Abstract
{
    public abstract class EndPointConnectAbstract : IEndPoint
    {
        private string _address;
        //Decided to make this abstract since Sia is a realtively young project - in time they may chance the address or agent name. Also allows for customizable address & agent which are allowed in sia settings
        public string Agent => "Sia-Agent";
        public abstract string Address { get; set; }
        //default constructor does not do anything except create the object, this can be overriden in implementation
        public EndPointConnectAbstract() { }
        public EndPointConnectAbstract(string siaAddress) { Address = $"http://{siaAddress}"; }
        //Each subclass should always have a connect method
        public abstract Task Connect(HttpClient client);
    }
}