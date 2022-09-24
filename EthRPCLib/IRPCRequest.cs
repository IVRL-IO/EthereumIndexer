using System.Text.Json.Serialization;

namespace eth_rpc_lib
{
    public interface IRPCRequest
    {
        [JsonPropertyName("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("method")]
        public string Method { get; set; }
    }
}