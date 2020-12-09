using PokemonWin.Entities;
using System;
using System.Threading.Tasks;

namespace PokemonWin.Service
{
    public class ProxyPokemon
    {
        public event Action ProcesoTerminado = delegate { };

        public async Task<PokemonListDto> GetListPokemons()
        {
            return await RestHelper.GetResponse<PokemonListDto>("pokemon");
        }
        
        public async Task<PokemonListDto> GetListPokemons(int limit, int offset)
        {
            var response = RestHelper.GetResponse<PokemonListDto>($"pokemon?limit={limit},offset={offset}");
            await response.ContinueWith(x =>
            {
                ProcesoTerminado?.Invoke();
            });
            return await response;
        }
    }
}