using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ares.Infrastructure.MvcExtensions;
using Ares.Infrastructure.Logging;

namespace Ares.Web.Admin.Controllers
{
    [Compress]
    public class BaseController : Controller
    {
        public BaseController()
        {

        }

        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            //LoggingFactory.GetLogger().Error(filterContext.Exception.Message, filterContext.Exception);
        }

        protected override void HandleUnknownAction(string actionName)
        {
            RedirectToAction("Index", "Login").ExecuteResult(this.ControllerContext);
        }
    }
}