using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WoodrowLuo.WebUI.Bee.Startup))]
namespace WoodrowLuo.WebUI.Bee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
