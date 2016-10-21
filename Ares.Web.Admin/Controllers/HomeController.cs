using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ares.Infrastructure.MvcExtensions;

namespace Ares.Web.Admin.Controllers
{
    public class HomeController : BaseController
    {
        //[CustomAuthorize(Role = "Administrator,Customer,Employee")]
        public ActionResult Index()
        {
            return View();
        }
    }
}