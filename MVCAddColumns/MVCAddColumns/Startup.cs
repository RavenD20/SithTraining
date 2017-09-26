using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAddColumns.Startup))]
namespace MVCAddColumns
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
