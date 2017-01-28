using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DA3___primero.Startup))]
namespace DA3___primero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
