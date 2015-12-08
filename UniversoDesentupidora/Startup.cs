using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversoDesentupidora.Startup))]
namespace UniversoDesentupidora
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
