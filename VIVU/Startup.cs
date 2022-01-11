using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VIVU.Startup))]
namespace VIVU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
