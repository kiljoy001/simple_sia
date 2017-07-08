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
        public List<StorageProof> storageproofs { get; set; }
        public List<SiafundInput> siafundinputs { get; set; }
        public List<SiafundOutput> siafundoutputs { get; set; }
        public List<Currency> minerfees { get; set; }
        public List<Byte[]> arbitrarydatas { get; set; }
        public List<TransactionSignature> transactionsignatures { get; set; }
    }
}
