using Ares.BusinessManager.Interfaces;
using Ares.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ares.Web.Admin.Controllers
{
    public class ConfigurationController : BaseController
    {
        private IAccountManager _actManager;
        public ConfigurationController(IAccountManager actManager)
        {
            _actManager = actManager;
        }

        // GET: Configurations
        public ActionResult Index()
        {
            return View(_actManager.FindAllBalanceTypes());
        }

        [HttpPost]
        public ActionResult UpdateBalance(BalanceType balanceType)
        {
            try
            {
                _actManager.UpdateBalanceType(balanceType);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(1);
        }
    }
}