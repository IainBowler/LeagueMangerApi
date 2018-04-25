using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapDatepicker.Startup))]
namespace BootstrapDatepicker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
