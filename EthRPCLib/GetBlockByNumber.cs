using eth_rpc_lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EthRPCLib
{
    /// <summary>
    /// 
    /// </summary>
    public class GetBlockByNumberResult : RPCBaseResponse<EthBlock>
    {
        [JsonConstructor]
        public GetBlockByNumberResult()
        {
        }
    }
}
