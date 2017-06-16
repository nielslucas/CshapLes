using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSHARP_Opdracht_WebShop.Models
{
    public static class SessionManager
    {
        public static List<Artikels> artikels
        {
            get { return (List<Artikels>)HttpContext.Current.Session["Artikels"]; }
            set { HttpContext.Current.Session["Artikels"] = value; }
        }
    }
}