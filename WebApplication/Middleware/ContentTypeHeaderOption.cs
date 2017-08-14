using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Middleware
{
    public class ContentTypeHeaderOption : HeaderOption
    {
        public ContentTypeHeaderOption(string value) : base(value)
        {
            Value = value;
        }
        public override string Header => "X-Content-Type-Options";

        public static ContentTypeHeaderOption Nosniff()
        {
            return new ContentTypeHeaderOption("nosniff");
        }
    }
}