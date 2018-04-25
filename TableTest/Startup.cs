using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TableTest.Startup))]
namespace TableTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
