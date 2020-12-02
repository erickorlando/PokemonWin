using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonWin
{
    public abstract class EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool RowStatus { get; set; }

        protected EntityBase()
        {
            RowStatus = true;
        }
    }
}