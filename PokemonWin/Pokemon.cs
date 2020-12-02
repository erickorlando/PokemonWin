using System;
using System.ComponentModel.DataAnnotations;

namespace PokemonWin
{
    public class Pokemon : EntityBase
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        public int Strenght { get; set; }

        public DateTime BirthDate { get; set; }
    }
}