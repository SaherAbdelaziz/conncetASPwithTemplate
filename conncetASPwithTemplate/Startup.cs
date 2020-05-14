using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(conncetASPwithTemplate.Startup))]
namespace conncetASPwithTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
