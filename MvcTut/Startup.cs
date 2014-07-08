using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTut.Startup))]
namespace MvcTut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
