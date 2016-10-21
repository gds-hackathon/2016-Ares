using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ares.Web.Admin.Startup))]
namespace Ares.Web.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
