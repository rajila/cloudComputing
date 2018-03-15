using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pruebaMvc01.Startup))]
namespace pruebaMvc01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
