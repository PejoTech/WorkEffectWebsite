using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkEffect.Website.Startup))]
namespace WorkEffect.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
