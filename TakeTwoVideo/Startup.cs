using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TakeTwoVideo.Startup))]
namespace TakeTwoVideo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
