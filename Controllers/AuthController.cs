using KP.Common;
using KP.Common.Return;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage SignIn(LogInModel value)
        {
            try
            {
                // Write the list to the response body.
                var auth = new AuthorizeAttribute();
                auth.Users = value.username;

                //SessionHelper.Set<AuthorizeAttribute>(auth);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, auth);
                return response;
            }
            catch (Exception e)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
                return response;
            }
        }

        public class LogInModel
        {
            public string username { get; set; }

            public string password { get; set; }
        }

        public class ObjectInfo
        {
            public string username { get; set; }

            public string fullname { get; set; }

            public string tel { get; set; }
        }
    }
}
