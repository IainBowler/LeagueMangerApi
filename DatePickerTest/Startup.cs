using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatePickerTest.Startup))]
namespace DatePickerTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
