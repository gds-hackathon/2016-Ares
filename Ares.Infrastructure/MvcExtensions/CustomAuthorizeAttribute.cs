using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Routing;

namespace Ares.Infrastructure.MvcExtensions
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class CustomAuthorizeAttribute: AuthorizeAttribute
    {
        public string Role { get; set; }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            string cookieName = FormsAuthentication.FormsCookieName;

            if (!filterContext.HttpContext.User.Identity.IsAuthenticated ||
                filterContext.HttpContext.Request.Cookies == null ||
                filterContext.HttpContext.Request.Cookies[cookieName] == null
            )
            {
                HandleUnauthorizedRequest(filterContext);
                return;
            }


            if (filterContext.HttpContext == null)
            {
                HandleUnauthorizedRequest(filterContext);
                return;

            }
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                HandleUnauthorizedRequest(filterContext);
                return;

            }
            if (!filterContext.HttpContext.User.IsInRole(Role))
            {
                HandleUnauthorizedRequest(filterContext);
                return;
            }
            var authCookie = filterContext.HttpContext.Request.Cookies[cookieName];
            var authTicket = FormsAuthentication.Decrypt(authCookie.Value);
            string[] roles = authTicket.UserData.Split(',');
            if (roles == null || roles.FirstOrDefault() != Role)
            {
                HandleUnauthorizedRequest(filterContext);
                return;
            }
            base.OnAuthorization(filterContext);
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            // System.Web.Security.FormsAuthentication.SignOut();
            filterContext.Result = new HttpUnauthorizedResult();
            filterContext.RequestContext.HttpContext.Response.Redirect("~/Account/Login");
            base.HandleUnauthorizedRequest(filterContext);
        }
    }
}
