using simple_sia_connect.Classes.Abstract;

namespace simple_sia_connect.Classes.Consensus
{
    class ConsensusValidateTransactionSet: EndPointPostAbstract
    {
        public ConsensusValidateTransactionSet(string siaAddress) : base(siaAddress)
        {
        }

        ConsensusValidateTransactionSet()
        {
            Address = "http://localhost:9980/consensus/validate/transactionset";
        }
        public override string Address { get; set; }
    }
}
