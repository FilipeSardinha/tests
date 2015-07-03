using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Listacontactos.Startup))]
namespace Listacontactos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
