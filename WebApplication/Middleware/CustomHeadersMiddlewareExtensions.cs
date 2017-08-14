using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Middleware;
using WebApplication.Middleware.Policies;

namespace Owin
{
    public static class CustomHeadersMiddlewareExtensions
    {
        /// <summary>
        /// Adds middleware to web application pipeline to add security headers to response
        /// </summary>
        /// <param name="appBuilder">the application builder passed to the Config method.</param>
        public static void UseCostumHeadersMiddleware(this IAppBuilder appBuilder, PolicyHeaderCollection policies)
        {
            appBuilder.Use<CustomHeadersMiddleware>(policies);
        }
    }
}