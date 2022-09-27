using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EthereumClientLibrary
{
    public class BaseRequest: IRequest
    {
        /// <summary>
        /// Defaults to 2.0
        /// </summary>
        [JsonPropertyName("jsonrpc")]
        public string Jsonrpc { get; set; } = "2.0";

        [JsonPropertyName("method")]
        public string Method { get; set; } = string.Empty;

        [JsonPropertyName("params")]
        public List<object>? Params { get; set; } = new List<Object>();

        [JsonPropertyName("id")]
        public int Id { get; set; } = new Random(Environment.CurrentManagedThreadId).Next();
    }


}
