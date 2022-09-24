using eth_rpc_lib;
using EthRPCApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using RestSharp;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using EthRPCLib;

namespace eth_index.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("[controller]", Name ="eth_syncing")]
    [Produces("application/json")]
    public class Ethereum : ControllerBase
    {


        private readonly ILogger<Ethereum> _logger;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public Ethereum(ILogger<Ethereum> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Provides Syncing status from Geth RPC
        /// </summary>
        /// <returns>Returns null if syncing is false otherwise provides <see cref="SyningResult"/></returns>
        [HttpGet()]
        [Route("[controller]/[action]")]
        public RPCBaseResponse<SyningResult?>? Syncing()
        {
            return new RPCClient<RPCBaseResponse<SyningResult?>?>().ExcuteCall(EthRPCMethods.Syncing);
        }

        /// <summary>
        /// Provides Syncing status from Geth RPC
        /// </summary>
        /// <returns>Returns null if syncing is false otherwise provides <see cref="SyningResult"/></returns>
        [HttpGet()]
        [Route("[controller]/[action]")]
        public BlockNumberResult? BlockNumber()
        {
            return new RPCClient<BlockNumberResult?>().ExcuteCall(EthRPCMethods.BlockNumber);
        }

        /// <summary>
        /// Provides Syncing status from Geth RPC
        /// </summary>
        /// <returns>Returns null if syncing is false otherwise provides <see cref="SyningResult"/></returns>
        [HttpGet()]
        [Route("[controller]/[action]")]
        public GetBlockByNumberResult GetBlockByNumber(int? BlockId)
        {
            return new RPCClient<GetBlockByNumberResult>().ExcuteCall(EthRPCMethods.GetBlockByNumber, new object[] { BlockId != null ? BlockId : "latest", false });
        }

        /// <summary>
        /// Returns true or false if syncing.
        /// </summary>
        /// <exception cref="EthereumConsensusClientException">Thrown is consensus client is not running</exception>
        /// <returns>True if syncing or False if not Syncing</returns>
        [HttpGet()]
        [Route("[controller]/[action]")]
        public bool IsSyncing()
        {
            var sync = this.Syncing();
            var block = this.BlockNumber();
            // On null we are not sinking
            if (sync == null) {
                return false;
            } else if (block?.Result != "0x0" && sync == null)
            {
                throw new EthereumConsensusClientException();
            } else if (sync != null) {
                return true;
            }


            return false;
        }
    }
}