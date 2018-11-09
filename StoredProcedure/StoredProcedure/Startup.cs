using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoredProcedure.Startup))]
namespace StoredProcedure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
