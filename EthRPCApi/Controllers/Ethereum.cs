using eth_rpc_lib;
using EthRPCApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using RestSharp;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

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
        public SyningResult? Syncing()
        {
            var client = new RestClient(Settings.RcpURL);
            var request = new RestRequest
            {
                Method = Method.Post
            };
            request.AddHeader("Content-Type", "application/json");
            var requestRPC = new RPCBaseRequest
            {
                Method = EthRPCMethods.Syncing,
                Id = 1
            };

            var body = JsonSerializer.Serialize(requestRPC); ;
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            if (response?.Content?.Length != 0 && response.Content.Contains("startingBlock"))
            {
                return JsonSerializer.Deserialize<RPCBaseResponse<SyningResult>>(response?.Content)?.Result;

            }
            return null;
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
            // On null we are not sinking
            if(sync == null) { 
                return false; 
            } else
            {

            }

            
            return false;
        }
    }
}