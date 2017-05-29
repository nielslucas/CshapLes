using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShopMVC.Models
{
    public class Pokemon
    {
        public int ID { get; set; }

        [Required]
        [Display(Name="Pokemon name")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Trainer")]
        public int TrainerID { get; set; }
        public Trainer Trainer { get; set; }

        [Required]
        [Display(Name="Pokemon Type")]
        public PokeType Type { get; set; }

        [Required]
        [Range(1,100, ErrorMessage = "The Pokemon level has to be betwwen 1 and 100")]
        public int Level { get; set; }        
    }

    public enum PokeType
    {
        FIRE,
        WATER,
        GRASS,
        ELECTRIC,
        DRAGON
    }
}