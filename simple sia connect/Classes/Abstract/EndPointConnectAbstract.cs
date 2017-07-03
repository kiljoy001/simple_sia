/*
This abstract class was created to make http GET connections easy. It implements IEndpoint and IDisposable.
*/

using System;
using System.Threading.Tasks;

namespace simple_sia_connect.Classes.Daemon
{
    public abstract class EndPointConnectAbstract : IEndPoint, IDisposable
    {
        public abstract string Agent { get; }
        public abstract string Address { get; }
        private bool _disposed = false;

        public abstract Task Connect(string agentName, string agentAddress);

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