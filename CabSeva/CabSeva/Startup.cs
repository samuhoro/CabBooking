using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CabSeva.Startup))]
namespace CabSeva
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
