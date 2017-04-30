using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OutfitsApp.Startup))]
namespace OutfitsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
