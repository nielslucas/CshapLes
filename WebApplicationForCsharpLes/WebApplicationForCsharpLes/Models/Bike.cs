using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationForCsharpLes.Models
{
    public class Bike
    {
        public int ID { get; set; }
        public BikeType Type { get; set;}
        public int RegistrationNumber { get; set; }
        public int PersonID { get; set; }
        public Person Owner { get; set; }
    }

    public enum BikeType
    {
        MOTORBIKE,
        BICYCLE,
        TANDEM
    }
}