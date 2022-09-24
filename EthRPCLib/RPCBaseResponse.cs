using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace eth_rpc_lib
{
    public class RPCBaseResponse<T>: IRPCResult<T>
    {

        [JsonPropertyName("jsonrpc")]
        public string Jsonrpc { get; set; } = "2.0";

        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("result")]
        public T Result { get; set; }
    }
}
