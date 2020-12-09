using System.Collections.Generic;

namespace PokemonWin.Entities
{
    public class PokemonListDto
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public object Previous { get; set; }
        public List<PokemonResultDto> Results { get; set; }
    }
}