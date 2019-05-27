using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200395023_app2project.Startup))]
namespace _200395023_app2project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
