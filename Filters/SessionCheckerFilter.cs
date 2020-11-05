using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.WebHost;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using WebApplication.Helper;

namespace WebApplication.Filters
{
    public class SessionCheckerFilterAttribute : ActionFilterAttribute
    {
        public Type type { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                var uInfo = filterContext.HttpContext.Session[AppConstants.USER_INFO] as AuthorizeAttribute;
                if (uInfo == null)
                {
                    throw new Exception("Session is expired");
                }
            }
            catch (Exception)
            {
                var urlHelper = new UrlHelper(HttpContext.Current.Request.RequestContext);
                string redirectUrl = urlHelper.Action("Login", "Home", new { area = "" });
                filterContext.Result = new RedirectResult(redirectUrl);
            }
            base.OnActionExecuting(filterContext);
        }

        public SessionCheckerFilterAttribute()
        {
            this.type = typeof(AuthorizeAttribute);
        }

        private HttpResponseMessage SetUnauthorized()
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            msg.StatusCode = HttpStatusCode.Unauthorized;
            msg.Content = new StringContent("Session is expired");
            return msg;
        }
    }

    public class SessionControllerHandler : HttpControllerHandler, IRequiresSessionState
    {
        public SessionControllerHandler(RouteData routeData) : base(routeData)
        { }
    }

    public class SessionHttpControllerRouteHandler : HttpControllerRouteHandler
    {
        protected override IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new SessionControllerHandler(requestContext.RouteData);
        }
    }
}