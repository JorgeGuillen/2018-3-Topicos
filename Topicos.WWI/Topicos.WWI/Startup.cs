using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Topicos.WWI.Startup))]
namespace Topicos.WWI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
