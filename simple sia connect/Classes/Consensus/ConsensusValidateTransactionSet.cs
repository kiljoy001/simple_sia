using System;
using System.Collections.Generic;
using System.Text;
using simple_sia_connect.Classes.Abstract;
using System.Threading.Tasks;
using simple_sia_connect.Classes.JSON_Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace simple_sia_connect.Classes.Consensus
{
    class ConsensusValidateTransactionSet: EndPointPostAbstract
    {
        public override string Address { set => Address = "http://localhost:9980/consensus/validate/transactionset"; get => Address; }
    }
}
