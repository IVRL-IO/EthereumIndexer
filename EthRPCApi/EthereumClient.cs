using EthereumClientLibrary;
using RestSharp;
using System.Text.Json;

namespace BlockchainRestAPI
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Response type</typeparam>
    public class EthereumClient<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MethodName"><seealso cref="EthMethods"/><seealso cref="NetMethods"/><seealso cref="WebMethods"/></param>
        /// <returns></returns>
        public T? ExcuteCall(string MethodName)
        {
            var client = new RestClient(Settings.RcpURL);
            var request = new RestRequest
            {
                Method = Method.Post
            };
            request.AddHeader("Content-Type", "application/json");
            var requestRPC = new BaseRequest
            {
                Method = MethodName,
                Id = 1
            };

            var body = JsonSerializer.Serialize(requestRPC); ;
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            if (response.Content != null && response.Content?.Length != 0)
            {
                return JsonSerializer.Deserialize<T>(response?.Content ?? String.Empty);

            }
            return default(T);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MethodName"></param>
        /// <param name="Params"></param>
        /// <returns></returns>
        public T? ExcuteCall(string MethodName, params object[] Params)
        {
            var client = new RestClient(Settings.RcpURL);
            var request = new RestRequest
            {
                Method = Method.Post
            };
            request.AddHeader("Content-Type", "application/json");
            var requestRPC = new BaseRequest
            {
                Method = MethodName,
                Id = 1,
                Params = Params.ToList()
            };

            var body = JsonSerializer.Serialize(requestRPC); ;
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            if (response.Content != null && response.Content?.Length != 0)
            {
                return JsonSerializer.Deserialize<T>(json: response.Content ?? string.Empty);

            }
            return default;
        }
    }
}
