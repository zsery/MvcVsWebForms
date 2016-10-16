using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCZdenek.Startup))]
namespace MVCZdenek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
