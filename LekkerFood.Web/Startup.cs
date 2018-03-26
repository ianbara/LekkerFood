using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LekkerFood.Web.Startup))]
namespace LekkerFood.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
