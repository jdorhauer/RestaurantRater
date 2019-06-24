using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResaurantRaterMVC.Startup))]
namespace ResaurantRaterMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
