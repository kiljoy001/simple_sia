/*
This abstract class was created to make http GET connections easy. It implements IEndpoint and IDisposable.
*/

using System;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Daemon
{
    public abstract class EndPointConnectAbstract : IEndPointFactory
    {
        //Decided to make this abstract since Sia is a realtively young project - in time they may chance the address or agent name. Also allows for customizable address & agent which are allowed in sia settings
        protected abstract string Agent { get; }
        protected abstract string Address { get; }
        private bool _disposed = false;
        //default constructor does not do anything
        public EndPointConnectAbstract();
        //constructor that sets the members up
        public EndPointConnectAbstract(string agent_name, string address_name)
        {
            Agent = agent_name;
            Address = address_name;
        }
        protected abstract Task Connect();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this._disposed) return;
            if (disposing)
            {
                this.Dispose();
            }
            _disposed = true;
        }
        
        
    }
}