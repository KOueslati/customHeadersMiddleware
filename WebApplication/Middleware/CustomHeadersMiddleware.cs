using System.Collections.Generic;
using System.Threading.Tasks;
using Owin;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;
using Microsoft.Owin;
using WebApplication.Middleware.Policies;

namespace WebApplication.Middleware
{
    public class CustomHeadersMiddleware
    {
        private AppFunc _next;
        private readonly PolicyHeaderCollection _policies;
        
        public CustomHeadersMiddleware(AppFunc next, PolicyHeaderCollection policies)
        {
            _next = next;
            _policies = policies;
        }
        
        public async Task Invoke(IDictionary<string, object> env)
        {
            var context = new OwinContext(env);

            if (context == null)
            {
                throw new System.ArgumentNullException(nameof(context));
            }

            foreach(var policy in _policies.Values)
            {
                context.Response.Headers.Append(policy.Header, policy.Value);
            }

            await _next(env);
        }
    }
}