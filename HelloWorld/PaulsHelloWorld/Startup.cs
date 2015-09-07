using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaulsHelloWorld.Startup))]
namespace PaulsHelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
