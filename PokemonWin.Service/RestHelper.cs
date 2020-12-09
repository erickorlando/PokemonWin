using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;

namespace PokemonWin.Service
{
    public class RestHelper 
    {
        private static RestClient _restClient;

        public static async Task<TResponse> GetResponse<TResponse>(string resource)
            where TResponse : class, new()
        {
            _restClient ??= new RestClient("https://pokeapi.co/api/v2/");

            var restRequest = new RestRequest(resource, Method.GET);

            var response = await _restClient.ExecuteGetAsync<TResponse>(restRequest);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Data;
            }

            throw new InvalidOperationException(response.ErrorMessage);
        }

    }
}
