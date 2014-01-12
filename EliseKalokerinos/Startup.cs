using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EliseKalokerinos.Startup))]
namespace EliseKalokerinos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
