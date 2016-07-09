using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPlaces.Startup))]
namespace MyPlaces
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
