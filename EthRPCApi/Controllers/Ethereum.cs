using EthereumClientLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using RestSharp;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using BlockchainRestAPI;

namespace BlockchainRestAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api", Name ="API")]
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
        public BaseResponse<SyningResult?>? Syncing()
        {
            return new EthereumClient<BaseResponse<SyningResult?>?>().ExcuteCall(EthMethods.Syncing);
        }

        /// <summary>
        /// Provides Syncing status from Geth RPC
        /// </summary>
        /// <returns>Returns null if syncing is false otherwise provides <see cref="SyningResult"/></returns>
        [HttpGet()]
        [Route("[controller]/[action]")]
        public BlockNumberResult? BlockNumber()
        {
            return new EthereumClient<BlockNumberResult?>().ExcuteCall(EthMethods.BlockNumber);
        }

        /// <summary>
        /// Provides Syncing status from Geth RPC, if no BlockId is passed in latest block is returned
        /// </summary>
        /// <returns>Returns null if syncing is false otherwise provides <see cref="SyningResult"/></returns>
        [HttpGet()]
        [Route("[controller]/[action]")]
        public GetBlockByNumberResponse? GetBlockByNumber(int? BlockId)
        {
            return new EthereumClient<GetBlockByNumberResponse>().ExcuteCall(EthMethods.GetBlockByNumber, new object[] { BlockId != null ? BlockId : "latest", true });
        }

        /// <summary>
        /// Provides wallet balance
        /// </summary>
        /// <returns>Returns null if syncing is false otherwise provides <see cref="SyningResult"/></returns>
        [HttpGet()]
        [Route("[controller]/[action]")]
        public BaseResponse<int>? GetWalletBalance(string Address)
        {
            return new EthereumClient<BaseResponse<int>>().ExcuteCall(EthMethods.GetBalance, new object[] { "0x8D97689C9818892B700e27F316cc3E41e17fBeb9", "latest" });
        }

        /// <summary>
        /// Returns balances from all sources (NFT's, alt coins, etc)
        /// </summary>
        /// <returns>Returns null if syncing is false otherwise provides <see cref="SyningResult"/></returns>
        [HttpGet()]
        [Route("[controller]/[action]")]
        public int? GetWalletBalances(string Address)
        {
            return new EthereumClient<int>().ExcuteCall(EthMethods.GetBalance, new object[] { "0x8D97689C9818892B700e27F316cc3E41e17fBeb9", "latest" });
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