using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopMVC.Models
{
    public class Trainer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Motto { get; set; }
        public Gender Gender { get; set; }
        public ICollection<Pokemon> Pokemons { get; set; }
    }

    public enum Gender {
        MALE,
        FEMALE
    }
}