using simple_sia_library.Classes.Abstract;

namespace simple_sia_library.Classes.Consensus
{
    class ConsensusValidateTransactionSet: EndPointPostAbstract
    {
        public ConsensusValidateTransactionSet(string siaAddress) : base(siaAddress)
        {
            Address = $"http://{siaAddress}/consensus/validate/transactionset";
        }

        ConsensusValidateTransactionSet()
        {
            Address = "http://localhost:9980/consensus/validate/transactionset";
        }
    }
}
