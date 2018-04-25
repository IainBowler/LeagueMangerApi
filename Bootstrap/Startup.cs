using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StyleChanger.Startup))]
namespace StyleChanger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
