using Ares.BusinessManager.Interfaces;
using Ares.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ares.Web.Admin.Controllers
{
    public class EmployeeController : Controller
    {
        IUserManager _userManager;
        ITransactionManager _transactionManager;

        public EmployeeController(
            IUserManager userManager,
            ITransactionManager txnManager)
        {
            _userManager = userManager;
            _transactionManager = txnManager;
        }

        // GET: Employees
        public ActionResult Index()
        {
            string userId = "";
            var cookie = HttpContext.Request.Cookies[Constants.Cookie_UserIdName];
            if (cookie != null && !string.IsNullOrEmpty(cookie.Value))
            {
                userId = cookie.Value;

                var employee = _userManager.GetEmployeeByUserId(int.Parse(userId));
                var txns = _transactionManager.FindTransactionsHistory(employee.EmployeeId, 0, 10);

                return View(txns);
            }

            return View();
        }
    }
}