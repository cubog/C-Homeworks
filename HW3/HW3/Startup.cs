using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW3.Startup))]
namespace HW3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
