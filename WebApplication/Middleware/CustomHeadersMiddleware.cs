using System.Collections.Generic;
using System.Threading.Tasks;
using Owin;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;
using Microsoft.Owin;

namespace WebApplication.Middleware
{
    public class CustomHeadersMiddleware
    {
        private AppFunc _next;

        public CustomHeadersMiddleware(AppFunc next)
        {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> env)
        {
            var context = new OwinContext(env);

            if(context == null)
            {
                throw new System.ArgumentNullException(nameof(context));
            }

            context.Response.Headers.Add("X-Content-Type-Options", new string[] { "nosniff" });

            await _next(env);
        }
    }
}