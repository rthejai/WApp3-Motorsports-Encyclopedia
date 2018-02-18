using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MotorsportsEncyclopedia.Startup))]
namespace MotorsportsEncyclopedia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
