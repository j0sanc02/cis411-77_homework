using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SanchezPetStore.Startup))]
namespace SanchezPetStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
