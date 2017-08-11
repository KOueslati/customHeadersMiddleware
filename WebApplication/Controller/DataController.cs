using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controller
{
    public class DataController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetData()
        {
            var obj = new { firstname = "khaled", lastname = "oueslati" };

            return Ok(obj);
        }
    }
}
