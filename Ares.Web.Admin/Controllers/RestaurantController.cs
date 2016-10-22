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
    public class RestaurantController : BaseController
    {
        private ITransactionManager _txnManager;
        private IUserManager _userManager;
        private IAccountManager _accountManager;

        public RestaurantController(
            ITransactionManager txnManager,
            IUserManager userManager,
            IAccountManager accountManager)
        {
            _txnManager = txnManager;
            _userManager = userManager;
            _accountManager = accountManager;
        }

        // GET: Restaurant
        public ActionResult Index(int? pageIndex)
        {
            return View(_userManager.FindAllCustomers());
        }

        public ActionResult Update(int userId)
        {
            var customer = _userManager.GetCustomerByUserId(userId);
            return PartialView("_UpdateView", customer);
        }

        [HttpPost]
        public ActionResult Update(Customer customer)
        {
            _userManager.UpdateCustomer(customer);
            //return PartialView("_UpdateView", customer);
            return RedirectToAction("index", new { pageIndex = 0 });
        }

        public ActionResult Transactions(int customerId, int pageIndex)
        {
            List<TransactionModel> txnModels = null;

            txnModels = new List<TransactionModel>();
            var txns = _txnManager.FindTransactionsHistoryByCustomer(customerId, pageIndex, 10);

            foreach (var item in txns)
            {
                var employee = _userManager.FindByEmployeeId(item.EmployeeId);
                var t = (TransactionModel)item;
                t.EmployeeName = employee == null ? "N/A" : employee.EmployeeName;
                txnModels.Add(t);
            }
            return View(txnModels);
        }

        public ActionResult Registry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registry(RegistryModel cu)
        {
            if (!string.IsNullOrEmpty(cu.LoginName))
            {
                _accountManager.RegistryUser(cu.LoginName, cu.PhoneNum, cu.Password, cu.Name, RoleTypes.Customer);
            }

            return RedirectToAction("Index");
        }
    }
}