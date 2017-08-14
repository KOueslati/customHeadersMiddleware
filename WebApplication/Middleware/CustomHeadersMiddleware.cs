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
        private readonly IHeaderOption _headerOption;

        public CustomHeadersMiddleware(AppFunc next, IHeaderOption headerOption)
        {
            _next = next;
            _headerOption = headerOption;
        }

        public async Task Invoke(IDictionary<string, object> env)
        {
            var context = new OwinContext(env);

            if(context == null)
            {
                throw new System.ArgumentNullException(nameof(context));
            }

            context.Response.Headers.Add(_headerOption.Header, new string[] { _headerOption.Value });
            
            await _next(env);
        }
    }
}