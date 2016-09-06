using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubApp1.Startup))]
namespace GitHubApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
