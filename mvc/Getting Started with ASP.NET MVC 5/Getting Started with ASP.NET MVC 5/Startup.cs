using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Getting_Started_with_ASP.NET_MVC_5.Startup))]
namespace Getting_Started_with_ASP.NET_MVC_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
