using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Court_work_1030.Startup))]
namespace MVC5Court_work_1030
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
