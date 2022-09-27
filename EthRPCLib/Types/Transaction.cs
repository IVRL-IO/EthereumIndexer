using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EthereumClientLibrary
{
    public class Transaction
    {
        [JsonPropertyName("blockHash")]
        public string BlockHash { get; set; } = string.Empty;

        [JsonPropertyName("blockNumber")]
        public string BlockNumber { get; set; } = string.Empty;

        [JsonPropertyName("from")]
        public string From { get; set; } = string.Empty;

        [JsonPropertyName("gas")]
        public string Gas { get; set; } = string.Empty;

        [JsonPropertyName("gasPrice")]
        public string HasPrice { get; set; } = string.Empty;

        [JsonPropertyName("hash")]
        public string Hash { get; set; } = string.Empty;

        [JsonPropertyName("input")]
        public string Input { get; set; } = string.Empty;

        [JsonPropertyName("nonce")]
        public string Nonce { get; set; } = string.Empty;

        [JsonPropertyName("to")]
        public string To { get; set; } = string.Empty;

        [JsonPropertyName("transactionIndex")]
        public string TransactionIndex { get; set; } = string.Empty;

        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("chainId")]
        public string ChainId { get; set; } = string.Empty;

        [JsonPropertyName("v")]
        public string V { get; set; } = string.Empty;

        [JsonPropertyName("r")]
        public string R { get; set; } = string.Empty;

        [JsonPropertyName("s")]
        public string S { get; set; } = string.Empty;

        [JsonPropertyName("maxFeePerGas")]
        public string MaxFeePerGas { get; set; } = string.Empty;

        [JsonPropertyName("maxPriorityFeePerGas")]
        public string MaxPriorityFeePerGas { get; set; } = string.Empty;

        [JsonPropertyName("accessList")]
        public List<object> AccessList { get; set; } = new List<object>();
    }
}
