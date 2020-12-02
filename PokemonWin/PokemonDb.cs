using Microsoft.EntityFrameworkCore;

namespace PokemonWin
{
    public class PokemonDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("server=localhost;database=PokemonDb;user=root;password=pa$$W0rD");
        }

        public DbSet<Pokemon> Pokemons { get; set; }
    }
}
