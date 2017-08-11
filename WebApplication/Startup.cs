using Owin;
using System;
using System.Diagnostics;
using System.Web.Http;
using WebApplication.Middleware;


using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;

namespace WebApplication
{
    public class Startup
    {
        public static void Configuration(IAppBuilder appBuilder)
        {

            HttpConfiguration config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            appBuilder.UseCostumHeadersMiddleware();

            appBuilder.UseWebApi(config);
        }
    }
}