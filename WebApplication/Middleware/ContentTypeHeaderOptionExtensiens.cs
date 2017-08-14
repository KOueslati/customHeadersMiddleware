using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Middleware.Policies;

namespace WebApplication.Middleware
{
    public static class ContentTypeHeaderOptionExtensiens
    {
        public static PolicyHeaderCollection AddContentTypeHeaderNosniff(this PolicyHeaderCollection policies)
        {
            return policies.ApplyPolicy(ContentTypeHeaderOption.Nosniff());
        }
    }
}