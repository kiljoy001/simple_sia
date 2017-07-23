using System;
using Blake2Core;
using System.Collections.Generic;
using simple_sia_connect.Classes.JSON_Models;

/* These are helper classes created in order to build the transaction UTXO json output for validating a transaction. It is currently UNTESTED and most likely very buggy with the wrong types for the fields. The class field names are all from the sia code base and should match up correctly, with the exception of the field called data.
 */

public class SiacoinInput
{
	public SiacoinInputID parentid { get; set; }
    public UnlockConditions unlockconditions { get; set; }
}

public class SiacoinInputID
{
    public Hash data { get; set; }
}
public class SiacoinOutput
{
    public Currency value { get; set; }
    public UnlockHash unlockhash { get; set; }
}

public class SiafundInput
{
    public SiafundOutputID parentid { get; set; }
    public UnlockConditions unlockconditions { get; set; }
    public UnlockHash claimunlockhash { get; set; }
}

public class SiafundOutputID
{
    public Hash data { get; set; }
}
public class SiafundOutput
{
    public Currency value { get; set; }
    public UnlockHash unlockhash { get; set; }
    public Currency claimstart { get; set; }
}
public class FileContract
{
    public Decimal filesize { get; set; }
    public Hash filemerkleroot { get; set; }
    public BlockHeight windowstart { get; set; }
    public BlockHeight windowend { get; set; }
    public Currency payout { get; set; }
    public List<SiacoinOutput> validproofoutputs { get; set; }
    public List<SiacoinOutput> missedproofoutputs { get; set; }
    public UnlockHash unlockhash { get; set; }
    public Decimal revisionnumber { get; set; }
}

public class Hash
{
    public byte[] data { get; set; }
    private const int HashSize = 32;
    public byte[] Array()
    {
        return new byte[HashSize];
    }
}

public class FileContractRevision
{
    public FileContractID parentID { get; set; }
    public UnlockConditions unlockconditions { get; set; }
    public Decimal newrevisionnumber { get; set; }
    public Decimal newfilesize { get; set; }
    public Hash newmerkeleroot { get; set; }
    public BlockHeight newwindowstart { get; set; }
    public BlockHeight newwindowend { get; set; }
    public List<SiacoinOutput> newvalidproofoutputs { get; set; }
    public List<SiacoinOutput> newmissedproofoutputs { get; set; }
    public UnlockHash newunlockhash { get; set; }
}

public class BlockHeight
{
    public Decimal height { get; set; }
}

public class UnlockConditions
{
    public BlockHeight timelock { get; set; }
    public List<SiaPublicKey> publickeys { get; set; }
    public Decimal signaturesrequred { get; set; }
}

public class SiaPublicKey
{
    public Specifier algorithm { get; set; }
    public byte[] key { get; set; }
}

public class Specifier
{
    public byte[] data { get; set; } 
    private const int SpecifierLen = 16;
    public byte[] Array()
    {
        return new byte[SpecifierLen];
    }
}

public class UnlockHash
{
    public Hash data { get; set; }
}

public class FileContractID
{
    public Hash data { get; set; }
}

public class Currency
{
    public Decimal amount { get; set; }
}

public class SiacoinOutputID
{
    public Hash data { get; set; }
}

public class SegmentSize
{
    public uint data { get; set; }
}

public class Segment
{
    public byte[] data { get; set; }
    private SegmentSize _size { get; set; }
    public Segment(SegmentSize size)
    {
        _size = size;
        data = new byte[_size.data];
    }
}

public class StorageProof
{
    public FileContractID parentid { get; set; }
    public Segment segment { get; set; }
    Hash[] hashset { get; set; }
}

public class TransactionSignature
{
    Hash parentid {get; set;}
    Decimal publickeyindex {get; set;}
    BlockHeight timelock {get; set;}
    CoveredFields coveredfields {get; set;}
    Byte[] signature {get; set;}
}

public class CoveredFields
{
    Boolean wholetransaction {get; set;}
    Decimal[] Siacoininputs {get; set;}
    Decimal[] Siacoinoutputs {get; set;}
    Decimal[] filecontracts {get; set;}
    Decimal[] filecontractrevision {get; set;}
    Decimal[] storageproofs {get; set;}
    Decimal[] siafundinputs {get; set;}
    Decimal[] siafundoutputs {get; set;}
    Decimal[] minerfees {get; set;}
    Decimal[] arbitrarydata {get; set;}
    Decimal[] transactionsignatures {get; set;}
}

public class Block
{
    BlockID parentid { get; set; }
    BlockNonce nonce { get; set; }
    Timestamp timestamp { get; set; }
    SiacoinOutput[] minerpayouts { get; set; }
    Transaction[] transactions { get; set; }
}

public class BlockID
{
    Hash ID { get; set; }
}

public class BlockNonce
{
    byte[] data { get; set; }
    private const int nonce_size = 8;
    public byte[] Array()
    {
        return new byte[nonce_size];
    }
}

public class Timestamp
{
    Decimal stamp { get; set; }
    public Decimal CurrentTimestamp()
    {
        return (Decimal)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
    }

}

public class TimestampSlice
{
    Timestamp[] data { get; set; }
}

///For the /host[POST] command
///helper class for containing the values needed for posting for the commands that require more than value

public class Collateral
{
    Decimal hastings { get; set; }
    Byte size { get; set; }
    Block block { get; set; }
}

public class MinDownloadBandwidthPrice
{
    Decimal hasting { get; set; }
    Byte size { get; set; }
}

public class MinStoragePrice
{
    Decimal hastings { get; set; }
    Byte size { get; set; }
    Block block { get; set; }
}

public class MinUploadBandwidthPrice
{
    Decimal hasting { get; set; }
    Byte size { get; set; }
}

public class HostStorageFoldersAddOption
{
    String path { get; set; }
    Byte size { get; set; }
}

public class HostStorageFoldersRemoveOption
{
    String path { get; set; }
    Boolean force { get; set; } = false;
}