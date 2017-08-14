using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebApplication.Controller
{
    [RoutePrefix("users")]
    public class UsersController : ApiController
    {
        [HttpGet]
        public IHttpActionResult  GetUsers()
        {
            var obj = new { firstname = "khaled", lastname = "oueslati" };

            return Ok(obj);
        }
    }
}
