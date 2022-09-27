using System.Text.Json.Serialization;

namespace EthereumClientLibrary
{
    public interface IResponse<T>
    {
        [JsonPropertyName("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("result")]
        public T Result { get; set; }
    }
}