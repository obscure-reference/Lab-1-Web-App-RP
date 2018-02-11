using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_1_Web_Application.Startup))]
namespace Lab_1_Web_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
