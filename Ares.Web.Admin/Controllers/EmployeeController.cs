using Ares.BusinessManager.Interfaces;
using Ares.Core;
using Ares.Core.Domain;
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
        public ActionResult Index(int? pageIndex)
        {
            return View(_userManager.FindAllEmployees());
            //List<TransactionModel> txnModels = null;
            //if (!userId.HasValue)
            //{
            //    var cookie = HttpContext.Request.Cookies[Constants.Cookie_UserIdName];
            //    if (cookie != null && !string.IsNullOrEmpty(cookie.Value))
            //        userId = int.Parse(cookie.Value);
            //}

            //txnModels = new List<TransactionModel>();
            //var employee = _userManager.GetEmployeeByUserId(userId.Value);
            //var customer = _userManager.GetCustomerByUserId(userId.Value);
            //var txns = _transactionManager.FindTransactionsHistory(employee.EmployeeId, pageIndex ?? 0, 10);

            //foreach (var item in txns)
            //{
            //    var t = (TransactionModel)item;
            //    t.CustomerName = customer.CustomerName;
            //    txnModels.Add(t);
            //}
            //return View(txnModels);
        }
    }
}