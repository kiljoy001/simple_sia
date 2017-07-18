using simple_sia_connect.Classes.Abstract;

namespace simple_sia_connect.Classes.Consensus
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
