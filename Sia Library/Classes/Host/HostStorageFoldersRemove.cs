using simple_sia_library.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_library.Classes.Host
{
    class HostStorageFoldersRemove : EndPointPostAbstract
    {
        public HostStorageFoldersRemove()
        {
            Address = "http://localhost:9980/host/storage/folders/remove";
        }

        public HostStorageFoldersRemove(string siaAddres) : base(siaAddres)
        {
            Address = $"http://{siaAddres}/host/storage/folders/remove";
        }
    }
}
