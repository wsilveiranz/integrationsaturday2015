using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntegrationSaturdayWeb101.Startup))]
namespace IntegrationSaturdayWeb101
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
