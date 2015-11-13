using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminPanelMVC.Startup))]
namespace AdminPanelMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
