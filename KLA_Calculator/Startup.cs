using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KLA_Calculator.Startup))]
namespace KLA_Calculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
