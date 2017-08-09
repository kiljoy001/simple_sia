using System;
using System.Collections.Generic;

namespace simple_sia_connect.Classes.JSON_Models
{
    class Transaction
    {
        public List<SiacoinInput> Siacoininputs { get; set; }
        public List<SiacoinOutput> Siacoinoutputs { get; set; }
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
