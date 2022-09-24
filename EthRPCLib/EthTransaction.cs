using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EthRPCLib
{
    public class EthTransaction
    {
        [JsonConstructor]
        public EthTransaction(string blockHash, string blockNumber, string from, string gas, string gasPrice, string hash, string input, string nonce, string to, string transactionIndex, string value, string type, string chainId, string v, string r, string s, string maxFeePerGas, string maxPriorityFeePerGas, List<object> accessList)
        {
            this.blockHash = blockHash;
            this.blockNumber = blockNumber;
            this.from = from;
            this.gas = gas;
            this.gasPrice = gasPrice;
            this.hash = hash;
            this.input = input;
            this.nonce = nonce;
            this.to = to;
            this.transactionIndex = transactionIndex;
            this.value = value;
            this.type = type;
            this.chainId = chainId;
            this.v = v;
            this.r = r;
            this.s = s;
            this.maxFeePerGas = maxFeePerGas;
            this.maxPriorityFeePerGas = maxPriorityFeePerGas;
            this.accessList = accessList;
        }

        

        public string blockHash { get; set; }
        public string blockNumber { get; set; }
        public string from { get; set; }
        public string gas { get; set; }
        public string gasPrice { get; set; }
        public string hash { get; set; }
        public string input { get; set; }
        public string nonce { get; set; }
        public string to { get; set; }
        public string transactionIndex { get; set; }
        public string value { get; set; }
        public string type { get; set; }
        public string chainId { get; set; }
        public string v { get; set; }
        public string r { get; set; }
        public string s { get; set; }
        public string maxFeePerGas { get; set; }
        public string maxPriorityFeePerGas { get; set; }
        public List<object> accessList { get; set; }
    }
}
