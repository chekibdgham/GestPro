using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestPro.WebUI.Startup))]
namespace GestPro.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
