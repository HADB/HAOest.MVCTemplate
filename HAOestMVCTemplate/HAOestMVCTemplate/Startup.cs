using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HAOestMVCTemplate.Startup))]
namespace HAOestMVCTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
