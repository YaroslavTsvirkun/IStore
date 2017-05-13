using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IStore.Startup))]
namespace IStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
