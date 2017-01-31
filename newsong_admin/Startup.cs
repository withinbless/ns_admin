using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(newsong_admin.Startup))]
namespace newsong_admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
