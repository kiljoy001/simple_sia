using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace simple_sia_connect.Classes.JSON_Models
{
    class JsonUtxoModel
    {
        public string blockid { get; set; }
        public string difficulty { get; set; }
        public string estimatedhashrate { get; set; }
        public int height { get; set; }
        public int maturitytimestamp { get; set; }
        public List<int> target { get; set; }
        public string totalcoins { get; set; }
        public int minerpayoutcount { get; set; }
        public int transactioncount { get; set; }
        public int siacoininputcount { get; set; }
        public int siacoinoutputcount { get; set; }
        public int filecontractcount { get; set; }
        public int filecontractrevisioncount { get; set; }
        public int storageproofcount { get; set; }
        public int siafundinputcount { get; set; }
        public int siafundoutputcount { get; set; }
        public int minerfeecount { get; set; }
        public int arbitrarydatacount { get; set; }
        public int transactionsignaturecount { get; set; }
        public string activecontractcost { get; set; }
        public int activecontractcount { get; set; }
        public string activecontractsize { get; set; }
        public string totalcontractcost { get; set; }
        public string totalcontractsize { get; set; }
        public string totalrevisionvolume { get; set; }

    }
}
