using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebApplication.Controller
{
    public class DatasController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetJavaScriptFile()
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);

            var path = HttpContext.Current.Server.MapPath("~/Files/javascript.js");
            var stream = new FileStream(path, FileMode.Open);
            response.Content = new StreamContent(stream);
            response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachement");
            response.Content.Headers.ContentDisposition.FileName = Path.GetFileName(path);
            response.Content.Headers.ContentLength = stream.Length;
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/javascript");


            return response;
        }
    }
}
