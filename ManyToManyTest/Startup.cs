using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManyToManyTest.Startup))]
namespace ManyToManyTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
