using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace simple_sia_connect.Classes.JSON_Models
{
    class JsonUtxoModel
    {
        public List<SiaCoinInput> siacoininputs { get; set; }
        public List<SiaCoinOutput> siacoinoutputs { get; set; }
        public List<FileContract> filecontracts { get; set; }
        public List<FileContractRevision> filecontractrevisions { get; set; }
        public string storageproofs { get; set; }
        public string siafundinputs { get; set; }
        public string siafundoutputs { get; set; }
        public string minerfees { get; set; }
        public string arbitrarydatas { get; set; }
        public string transactionsignatures { get; set; }
    }
}
