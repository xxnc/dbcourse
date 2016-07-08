using Microsoft.Owin;
using Owin;
using Spring.Context;
using Spring.Context.Support;

[assembly: OwinStartupAttribute(typeof(MVCWebDemo.Startup))]
namespace MVCWebDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
