using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Au_Comptoir_Noirci.Startup))]
namespace Au_Comptoir_Noirci
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
