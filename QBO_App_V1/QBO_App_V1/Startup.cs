using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QBO_App_V1.Startup))]
namespace QBO_App_V1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
