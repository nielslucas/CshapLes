using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class hello : System.Web.UI.Page
    {
        public string text;
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                text += "Hello World <br>";
            } 
        }
    }
}