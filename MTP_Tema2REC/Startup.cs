using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MTP_Tema2REC.Startup))]
namespace MTP_Tema2REC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
