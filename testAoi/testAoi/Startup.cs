using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testAoi.Startup))]
namespace testAoi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
