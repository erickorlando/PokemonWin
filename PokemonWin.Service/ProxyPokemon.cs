using PokemonWin.Entities;
using System;
using System.Threading.Tasks;

namespace PokemonWin.Service
{
    public class ProxyPokemon
    {
        public event Action<PokemonListDto> ProcesoTerminado = delegate { };

        public void GetListPokemons(int limit, int offset)
        {
            Task.Factory.StartNew(async () =>
            {
                var response = await RestHelper.GetResponse<PokemonListDto>($"pokemon?limit={limit},offset={offset}");

                ProcesoTerminado(response);
            });
        }
    }
}