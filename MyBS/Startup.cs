using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBS.Startup))]
namespace MyBS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
