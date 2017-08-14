using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Middleware.Policies;

namespace WebApplication.Middleware
{
    /// <summary>
    /// Extension methods for adding <see cref="ContentTypeHeaderOption"/> to a <see cref="PolicyHeaderCollection"/>
    /// </summary>
    public static class ContentTypeHeaderOptionExtensiens
    {
        /// <summary>
        /// Add policy X-Content-Type-option to response
        /// </summary>
        /// <param name="policies">The collection of policies</param>
        /// <returns>The collection of policies</returns>
        public static PolicyHeaderCollection AddContentTypeHeaderNosniff(this PolicyHeaderCollection policies)
        {
            return policies.ApplyPolicy(ContentTypeHeaderOption.Nosniff());
        }
    }
}