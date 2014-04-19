using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CPEWeb.Startup))]
namespace CPEWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
