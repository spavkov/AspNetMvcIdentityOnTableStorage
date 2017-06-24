using CloudMockApi.Models;
using CloudMockApi.Services;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudMockApi.Startup))]
namespace CloudMockApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
