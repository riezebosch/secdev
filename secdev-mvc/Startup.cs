using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(secdev_mvc.Startup))]
namespace secdev_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
