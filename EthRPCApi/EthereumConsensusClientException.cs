using static System.Net.WebRequestMethods;

namespace BlockchainRestAPI
{
    /// <summary>
    /// Exception if currentBlock = 0x0 and syncing is false.<see href="https://ethereum.org/en/developers/docs/nodes-and-clients/"/>
    /// </summary>
    public class EthereumConsensusClientException: Exception
    {
        /// <summary>
        /// Information on how to fix the exception
        /// </summary>
        public override string Message => "Ethereum consensus client missing";
    }
}
