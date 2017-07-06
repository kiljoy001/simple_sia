using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace simple_sia_connect.Classes.JSON_Models
{
    class JsonUtxoModel
    {
        string Blockid { get; set; }
        string Difficulty { get; set; }
        string EstimatedHashrate { get; set; }
        uint Height { get; set; }
        BigInteger Maturitytimestamp { get; set; }
        int[] Target { get; set; }
        string TotalCoins { get; set; }
        int MinerPayoutCount { get; set; }
        int TransactionCount { get; set; }
        int SiacoinInputCount { get; set; }
        int SiacoinOutoutCount { get; set; }
        int FileContractCount { get; set; }
        int FileContractRevisionCount { get; set; }
        int StorageProofCount { get; set; }
        int SiaFundInputCount { get; set; }
        int SiaFundOutputCount { get; set; }
        int MinerFeeCount { get; set; }
        int ArbitraryDataCount { get; set; }
        int TransactionSignatureCount { get; set; }
        string ActiveContractCost { get; set; }
        int ActiveContractCount { get; set; }
        string ActiveContractSize { get; set; }
        string TotalContractCost { get; set; }
        string TotalContractSize { get; set; }
        string TotalRevisionVolume { get; set; }
    }
}
