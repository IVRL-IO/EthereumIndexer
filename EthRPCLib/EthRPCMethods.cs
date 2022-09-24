using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eth_rpc_lib
{
    /// <summary>
    /// All Methods in the eth namespace.
    /// </summary>
    public static class EthRPCMethods
    {
        public const string Accounts = "eth_accounts";
        public const string BlockNumber = "eth_blockNumber";
        public const string Call = "eth_call";
        public const string Coinbase = "eth_coinbase";
        public const string CompileLLL = "eth_compileLLL";
        public const string CompileSerpent = "eth_compileSerpent";
        public const string CompileSolidity = "eth_compileSolidity";
        public const string EstimateGas = "eth_estimateGas";
        public const string GasPrice = "eth_gasPrice";
        public const string GetBalance = "eth_getBalance";
        public const string GetBlockByHash = "eth_getBlockByHash";
        public const string GetBlockByNumber = "eth_getBlockByNumber";
        public const string GetBlockTransactionCountByHash = "eth_getBlockTransactionCountByHash";
        public const string GetBlockTransactionCountByNumber = "eth_getBlockTransactionCountByNumber";
        public const string GetCode = "eth_getCode";
        public const string GetCompilers = "eth_getCompilers";
        public const string GetFilterChanges = "eth_getFilterChanges";
        public const string GetFilterLogs = "eth_getFilterLogs";
        public const string GetLogs = "eth_getLogs";
        public const string GetStorageAt = "eth_getStorageAt";
        public const string GetTransactionByBlockHashAndIndex = "eth_getTransactionByBlockHashAndIndex";
        public const string GetTransactionByBlockNumberAndIndex = "eth_getTransactionByBlockNumberAndIndex";
        public const string GetTransactionByHash = "eth_getTransactionByHash";
        public const string GetTransactionCount = "eth_getTransactionCount";
        public const string GetTransactionReceipt = "eth_getTransactionReceipt";
        public const string GetUncleByBlockHashAndIndex = "eth_getUncleByBlockHashAndIndex";
        public const string GetUncleByBlockNumberAndIndex = "eth_getUncleByBlockNumberAndIndex";
        public const string GetUncleCountByBlockHash = "eth_getUncleCountByBlockHash";
        public const string GetUncleCountByBlockNumber = "eth_getUncleCountByBlockNumber";
        public const string GetWork = "eth_getWork";
        public const string Hashrate = "eth_hashrate";
        public const string Mining = "eth_mining";
        public const string NewBlockFilter = "eth_newBlockFilter";
        public const string NewFilter = "eth_newFilter";
        public const string NewPendingTransactionFilter = "eth_newPendingTransactionFilter";
        public const string ProtocolVersion = "eth_protocolVersion";
        public const string SendRawTransaction = "eth_sendRawTransaction";
        public const string SendTransaction = "eth_sendTransaction";
        public const string Sign = "eth_sign";
        public const string SignTransaction = "eth_signTransaction";
        public const string SubmitHashrate = "eth_submitHashrate";
        public const string SubmitWork = "eth_submitWork";
        public const string Syncing = "eth_syncing";
        public const string UninstallFilter = "eth_uninstallFilter";
    }
}
