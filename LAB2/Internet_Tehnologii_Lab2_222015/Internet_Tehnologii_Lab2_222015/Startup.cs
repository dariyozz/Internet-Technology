using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Internet_Tehnologii_Lab2_222015.Startup))]
namespace Internet_Tehnologii_Lab2_222015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
