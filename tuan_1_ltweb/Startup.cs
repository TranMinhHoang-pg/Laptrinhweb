using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tuan_1_ltweb.Startup))]
namespace tuan_1_ltweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
