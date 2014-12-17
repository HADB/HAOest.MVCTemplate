using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HAOestMvcTemplate.Startup))]
namespace HAOestMvcTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
