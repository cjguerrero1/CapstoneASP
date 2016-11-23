using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DnDCompanion.Startup))]
namespace DnDCompanion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
