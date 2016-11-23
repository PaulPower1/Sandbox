using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaulsSecurity.Startup))]
namespace PaulsSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
