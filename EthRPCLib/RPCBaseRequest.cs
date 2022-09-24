using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace eth_rpc_lib
{
    public class RPCBaseRequest
    {
        /// <summary>
        /// Defaults to 2.0
        /// </summary>
        [JsonPropertyName("jsonrpc")]
        public string Jsonrpc { get; set; } = "2.0";

        [JsonPropertyName("method")]
        public string Method { get; set; }

        [JsonPropertyName("params")]
        public List<object>? Params { get; set; }
         
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }


}
