using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Ares.Web.Admin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            HttpApplication currentApp = (HttpApplication)sender;
            // Get current http request's httpcontext object
            HttpContext currentContext = currentApp.Context;
            if (currentContext.User != null)
            {
                // Verify user
                if (currentContext.Request.IsAuthenticated == true)
                {
                    System.Web.Security.FormsIdentity fi = (System.Web.Security.FormsIdentity)currentContext.User.Identity;
                    // Get authenticate ticket
                    System.Web.Security.FormsAuthenticationTicket ticket = fi.Ticket;
                    // Get user data
                    string userData = ticket.UserData;
                    string[] roles = userData.Split(',');
                    currentContext.User = new System.Security.Principal.GenericPrincipal(fi, roles);
                }
            }
        }
    }
}
