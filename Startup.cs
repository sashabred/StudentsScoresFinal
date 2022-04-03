using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentsScoresFinal.Startup))]
namespace StudentsScoresFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
