using Ares.BusinessManager.Implementation;
using Ares.BusinessManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ares.Web.Admin.Controllers
{
    public class LoginController : Controller
    {
        private IAccountManager _accountManager;

        public LoginController(IAccountManager accountManager)
        {
            _accountManager = accountManager;
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            _accountManager.Login(userName, password);
            // TODO: add things to coookies
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            // TODO: remove things from cookies
            return RedirectToAction("Login");
        }

    }
}