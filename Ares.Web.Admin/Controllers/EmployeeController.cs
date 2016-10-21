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

        }

        public ActionResult Transactions(int employeeId, int pageIndex)
        {
            List<TransactionModel> txnModels = null;

            txnModels = new List<TransactionModel>();
            var txns = _transactionManager.FindTransactionsHistory(employeeId, pageIndex, 10);
            var employee = _userManager.FindByEmployeeId(employeeId);

            foreach (var item in txns)
            {
                var customer = _userManager.FindByCustomerId(item.CustomerId);
                var t = (TransactionModel)item;
                t.CustomerName = customer.CustomerName;
                txnModels.Add(t);
            }
            return View(txnModels);
        }
    }
}