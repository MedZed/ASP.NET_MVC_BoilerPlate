using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App_Test.Startup))]
namespace App_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
