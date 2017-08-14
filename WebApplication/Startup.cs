using Owin;
using System;
using System.Diagnostics;
using System.Web.Http;
using WebApplication.Middleware;
using WebApplication.Middleware.Policies;
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

            appBuilder.UseCostumHeadersMiddleware(
                new PolicyHeaderCollection().AddHeadersSecurity()
                );

            appBuilder.UseWebApi(config);
        }
    }
}