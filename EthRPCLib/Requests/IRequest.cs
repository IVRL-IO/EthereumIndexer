using System.Text.Json.Serialization;

namespace EthereumClientLibrary
{
    public interface IRequest
    {
        [JsonPropertyName("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("method")]
        public string Method { get; set; }
    }
}