using EthereumClientLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EthereumClientLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class GetBlockByNumberResponse : BaseResponse<Block>
    {
        [JsonConstructor]
        public GetBlockByNumberResponse()
        {
        }
    }
}
