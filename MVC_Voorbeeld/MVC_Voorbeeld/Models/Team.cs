using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Voorbeeld.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PrimaryShortColor { get; set; }
        public string SecondaryShortColor { get; set; }
        public int Position { get; set; }
        public string City { get; set; }

    }
}