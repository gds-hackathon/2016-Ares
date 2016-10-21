using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ares.Web.Admin.Controllers
{
    public class ConfigurationController : Controller
    {
        // GET: Configurations
        public ActionResult Index()
        {
            return View();
        }
    }
}