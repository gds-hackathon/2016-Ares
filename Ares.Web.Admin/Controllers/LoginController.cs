using Ares.BusinessManager.Implementation;
using Ares.BusinessManager.Interfaces;
using Ares.Core;
using Ares.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Ares.Web.Admin.Controllers
{
    public class LoginController : BaseController
    {
        private IAccountManager _accountManager;

        public LoginController(IAccountManager accountManager)
        {
            _accountManager = accountManager;
        }

        // GET: Login
        public ActionResult Index()
        {
            var cookie = HttpContext.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (cookie != null && !string.IsNullOrEmpty(cookie.Value))
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            try
            {
                var loginResult = _accountManager.Login(userName, password);
                FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                        1,
                        userName,
                        DateTime.Now,
                        DateTime.Now.AddMinutes(3),
                        false,
                        loginResult.RoleType.ToString()
                        );
                string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                HttpCookie authCookie = new System.Web.HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);

                HttpContext.Response.Cookies.Add(authCookie);
                HttpContext.Response.Cookies.Add(new HttpCookie(Constants.Cookie_UserIdName, loginResult.UserId.ToString()));
                HttpContext.Response.Cookies.Add(new HttpCookie(Constants.Cookie_RoleTypeName, loginResult.RoleType.ToString()));

                switch (loginResult.RoleType)
                {
                    case RoleTypes.Customer:
                        return RedirectToAction("GetCustomerTransHistory", "Summary");
                    case RoleTypes.Employee:
                        return RedirectToAction("index", "Employee");
                    case RoleTypes.Administrator:
                        return RedirectToAction("GetAdministratorTransHistory", "Summary");
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View("Index");
            }
            

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            HttpCookie c = Request.Cookies[FormsAuthentication.FormsCookieName];
            c.Expires = DateTime.Now.AddDays(-1);

            Response.Cookies.Set(c);

            Session.Clear();
            return RedirectToAction("Index");
        }

    }
}