using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Middleware.Policies
{
    public static class PolicyHeaderCollectionExtensions
    {
        /// <summary>
        /// Add policy to policy collection
        /// </summary>
        /// <param name="policies"></param>
        /// <param name="headerOption"></param>
        /// <returns></returns>
        public static PolicyHeaderCollection ApplyPolicy(this PolicyHeaderCollection policies, IHeaderOption headerOption)
        {
            policies[headerOption.Header] = headerOption;

            return policies;
        }

        public static PolicyHeaderCollection AddHeadersSecurity(this PolicyHeaderCollection policies)
        {
            policies.AddContentTypeHeaderNosniff();

            return policies;
        }
    }
}