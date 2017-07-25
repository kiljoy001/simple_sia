using simple_sia_connect.Classes.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_sia_connect.Classes.Host
{
    class HostStorageFoldersAdd : EndPointPostAbstract
    {
        public HostStorageFoldersAdd()
        {
            Address = "http://localhost:9980/host/storage/folders/add";
        }

        public HostStorageFoldersAdd(string siaAddres) : base(siaAddres)
        {
            Address = $"http://{siaAddres}/host/storage/folders/add";
        }
    }
}
