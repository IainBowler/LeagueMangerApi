using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFUnitTest.Startup))]
namespace EFUnitTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
