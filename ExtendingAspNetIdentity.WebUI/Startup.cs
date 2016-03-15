using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExtendingAspNetIdentity.WebUI.Startup))]
namespace ExtendingAspNetIdentity.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
