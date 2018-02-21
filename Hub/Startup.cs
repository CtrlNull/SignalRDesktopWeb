using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(Hub.Startup))]

namespace Hub
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
