using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;

namespace EthRPCLib
{
    public class EthBlock
    {
        [JsonConstructor]
        public EthBlock(string baseFeePerGas, string difficulty, string extraData, string gasLimit, string gasUsed, string hash, string logsBloom, string miner, string mixHash, string nonce, string number, string parentHash, string receiptsRoot, string sha3Uncles, string size, string stateRoot, string timestamp, string totalDifficulty, List<string> transactions, string transactionsRoot, List<string> uncles)
        {
            this.baseFeePerGas = baseFeePerGas;
            this.difficulty = difficulty;
            this.extraData = extraData;
            this.gasLimit = gasLimit;
            this.gasUsed = gasUsed;
            this.hash = hash;
            this.logsBloom = logsBloom;
            this.miner = miner;
            this.mixHash = mixHash;
            this.nonce = nonce;
            this.number = number;
            this.parentHash = parentHash;
            this.receiptsRoot = receiptsRoot;
            this.sha3Uncles = sha3Uncles;
            this.size = size;
            this.stateRoot = stateRoot;
            this.timestamp = timestamp;
            this.totalDifficulty = totalDifficulty;
            this.transactions = transactions;
            this.transactionsRoot = transactionsRoot;
            this.uncles = uncles;
        }

        

        public string baseFeePerGas { get; set; }
        public string difficulty { get; set; }
        public string extraData { get; set; }
        public string gasLimit { get; set; }
        public string gasUsed { get; set; }
        public string hash { get; set; }
        public string logsBloom { get; set; }
        public string miner { get; set; }
        public string mixHash { get; set; }
        public string nonce { get; set; }
        public string number { get; set; }
        public string parentHash { get; set; }
        public string receiptsRoot { get; set; }
        public string sha3Uncles { get; set; }
        public string size { get; set; }
        public string stateRoot { get; set; }
        public string timestamp { get; set; }
        public string totalDifficulty { get; set; }
        public List<string> transactions { get; set; }
        public string transactionsRoot { get; set; }
        public List<string> uncles { get; set; }
    }
}
