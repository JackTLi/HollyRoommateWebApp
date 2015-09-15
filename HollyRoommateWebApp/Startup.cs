using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HollyRoommateWebApp.Startup))]
namespace HollyRoommateWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
