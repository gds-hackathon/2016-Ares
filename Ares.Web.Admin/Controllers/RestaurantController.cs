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
        public ActionResult Index(int? pageIndex)
        {
            return View(_userManager.FindAllCustomers());

            //var customer = _userManager.GetCustomerByUserId(userId);
            //var txns = _txnManager.FindTransactionsHistoryByCustomer(customer.CustomerId, pageIndex, 10);
            //return View(txns);
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
            return null;
        }
    }
}