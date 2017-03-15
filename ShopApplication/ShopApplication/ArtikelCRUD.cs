using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication
{
    public partial class Artikel
    {
        //create constructor
        public Artikel(string name, string description, decimal price, int stock)
        {
            Name = name;
            Description = description;
            Price = price;
            Storage = stock;
        }
    }
}
