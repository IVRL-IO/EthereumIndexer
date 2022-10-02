using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EthereumClientLibrary
{
    public class BaseResponse<T>: IResponse<T>
    {

        [JsonPropertyName("jsonrpc")]
        public string Jsonrpc { get; set; } = "2.0";

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("result")]
#pragma warning disable CS8601 // Possible null reference assignment.
        public T Result { get; set; } = default;
#pragma warning restore CS8601 // Possible null reference assignment.
    }
}
