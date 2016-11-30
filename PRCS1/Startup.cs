using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using PRCS.Models;
using PRCS1.Models;

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
