using System.Text.Json.Serialization;

namespace eth_rpc_lib
{
    public interface IRPCResult<T>
    {
        [JsonPropertyName("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("result")]
        public T Result { get; set; }
    }
}