using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CharacterGuideWebsite.Startup))]
namespace CharacterGuideWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
