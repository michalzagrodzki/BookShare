using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookShare.Startup))]
namespace BookShare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
