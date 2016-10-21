using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ares.Web.Admin.Controllers
{
    public class LogController : Controller
    {
        // GET: Logs
        public ActionResult Index()
        {
            return View();
        }
    }
}