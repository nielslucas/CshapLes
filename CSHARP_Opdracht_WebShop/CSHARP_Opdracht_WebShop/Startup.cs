using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSHARP_Opdracht_WebShop.Startup))]
namespace CSHARP_Opdracht_WebShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
