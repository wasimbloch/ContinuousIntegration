using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIWeb.Startup))]
namespace CIWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
