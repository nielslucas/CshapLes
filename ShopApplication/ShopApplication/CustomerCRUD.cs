using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication
{
    partial class Customer
    {
        public Customer(string name, string email, string street, int housenumber, string postcode, string place, string land, int phonenumber)
        {
            Name = name;
            Email = email;
            Street = street;
            HouseNumber = housenumber;
            Postcode = postcode;
            Place = place;
            Land = land;
            PhoneNumber = phonenumber;
        }
    }
}
