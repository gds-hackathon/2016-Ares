using Ares.BusinessManager.Interfaces;
using Ares.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ares.Web.Admin.Controllers
{
    public class RestaurantController : Controller
    {
        private ITransactionManager _txnManager;
        private IUserManager _userManager;

        public RestaurantController(
            ITransactionManager txnManager,
            IUserManager userManager)
        {
            _txnManager = txnManager;
            _userManager = userManager;
        }

        // GET: Restaurant
        public ActionResult Index()
        {
            string userId;
            var cookie = HttpContext.Request.Cookies[Constants.Cookie_UserIdName];
            if (cookie != null && !string.IsNullOrEmpty(cookie.Value))
            {
                userId = cookie.Value;
            }

            //_userManager
            return View();
        }
    }
}