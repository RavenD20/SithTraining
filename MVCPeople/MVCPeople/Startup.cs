using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPeople.Startup))]
namespace MVCPeople
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
