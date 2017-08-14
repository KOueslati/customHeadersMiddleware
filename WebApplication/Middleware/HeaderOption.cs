using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Middleware
{
    public abstract class HeaderOption : IHeaderOption
    {
        public abstract string  Header { get; }

        public string Value { get; set; }

        public HeaderOption(string value)
        {
            Value = value;
        }
    }
}