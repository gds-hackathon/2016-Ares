using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ares.Core.Domain;
using Ares.Core.Dto;
using Ares.Core.Repositories;
using Ares.BusinessManager.Interfaces;
using Ares.Infrastructure.MvcExtensions;
using Ares.Core;

namespace Ares.Web.Admin.Controllers
{
    public class SummaryController : BaseController
    {
        private ITransactionManager _transactionManager;
        private IUserManager _userManager;

        public SummaryController()
        {

        }

        public SummaryController(ITransactionManager transactionManager,IUserManager userManager)
        {
            _transactionManager = transactionManager;
            _userManager = userManager;
        }


        [CustomAuthorize(Role ="Customer")]
        [HttpGet]
        public ActionResult GetCustomerTransHistory()
        {
            string userId = HttpContext.Request.Cookies[Constants.Cookie_UserIdName].Value;
            var customer = _userManager.GetCustomerByUserId(int.Parse(userId));
            if (customer != null)
            {
                var result = _transactionManager.CheckTransactionByCustomerId(customer.CustomerId);
                return View(result);
            }

            return View();
        }



    }
}