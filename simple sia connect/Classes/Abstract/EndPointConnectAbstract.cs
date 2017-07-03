/*
This abstract class was created to make http GET connections easy. It implements IEndpoint and IDisposable.
*/

using System;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Daemon
{
    public abstract class EndPointConnectAbstract : IEndPoint, IDisposable
    {
        //Decided to make this abstract since Sia is a realtively young project - in time they may chance the address or agent name. Also allows for customizable address
        protected abstract string Agent { get; }
        protected abstract string Address { get; }
        private bool _disposed = false;

        protected abstract Task Connect(string agentName, string agentAddress);

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
        public IEndPoint GetObject()
            {

            }
    }
}