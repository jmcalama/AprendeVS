using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneASP.NET_1.Startup))]
namespace OneASP.NET_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
