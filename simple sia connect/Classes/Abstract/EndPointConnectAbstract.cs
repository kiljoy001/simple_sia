/*
This abstract class was created to make http GET connections easy. It implements IEndpoint and IDisposable.
*/

using System;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Daemon
{
    public abstract class EndPointConnectAbstract : IEndPoint, IDisposable
    {
        //Decided to make this abstract since Sia is a realtively young project - in time they may chance the address or agent name. Also allows for customizable address & agent which are allowed in sia settings
        public abstract string Agent { get; }
        public abstract string Address { get; }
        private bool _disposed = false;
        //default constructor does not do anything
        public EndPointConnectAbstract()
        {
            
        }

        
        public abstract Task Connect();

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