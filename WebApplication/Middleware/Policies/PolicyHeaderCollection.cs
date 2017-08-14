using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Middleware.Policies
{
    /// <summary>
    /// Define the policy to use for headers security
    /// </summary>
    public class PolicyHeaderCollection : Dictionary<string, IHeaderOption>
    {
    }
}