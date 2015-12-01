using Microsoft.Owin;
using Owin;

[assembly: OwinStartup (typeof (ServerDemo.Startup))]

namespace ServerDemo
{
    public class Startup
    {
        public void Configuration (IAppBuilder app)
        {
            app.MapSignalR ();
        }
    }
}