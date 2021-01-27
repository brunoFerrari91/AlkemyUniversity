using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlkemyUniversity.Startup))]
namespace AlkemyUniversity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
