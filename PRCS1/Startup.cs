using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRCS1.Startup))]
namespace PRCS1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
