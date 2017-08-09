using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Host
{
    class HostStorageFoldersResize : EndPointPostAbstract
    {
        public HostStorageFoldersResize()
        {
            Address = "http://localhost:9980/host/storage/folders/resize";
        }

        public HostStorageFoldersResize(string siaAddres) : base(siaAddres)
        {
            Address = $"http://{siaAddres}/host/storage/folders/resize";
        }
    }
}
