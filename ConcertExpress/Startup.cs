using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConcertExpress.Startup))]
namespace ConcertExpress
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
