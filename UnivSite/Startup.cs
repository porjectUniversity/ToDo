using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnivSite.Startup))]
namespace UnivSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
