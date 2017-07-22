using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
//TODO Create validator helper class, seems to be needed more than once. Once complete simpify GatewayConnect to use the new class.
namespace simple_sia_connect.Classes.Helper
{
    class NetAddressValidator
    {
        private string filter = @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])\:\d{1,5}$";

        public bool Validate(string address)
        {
            return Regex.Match(address, filter).Success;
        }
    }
}
