using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoMVC_Net_1.Startup))]
namespace ProyectoMVC_Net_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
