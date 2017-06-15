using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationForCsharpLes.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set;}
        public IQueryable Bikes { get; set;}
    }
}