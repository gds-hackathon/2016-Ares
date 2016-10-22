using Ares.BusinessManager.Interfaces;
using Ares.Core.Domain;
using Ares.Infrastructure.MvcExtensions;
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

        [CustomAuthorize(Role = "Administrator")]
        // GET: Configurations
        public ActionResult Index()
        {
            return View(_actManager.FindAllBalanceTypes());
        }

        [CustomAuthorize(Role = "Administrator")]
        public ActionResult UpdateBalance(int? balanceTypeId, int? newValue)
        {
            try
            {
                if (balanceTypeId.HasValue)
                {
                    var balanceType = _actManager.GetBalanceType(balanceTypeId.Value);
                    balanceType.Balance = newValue;
                    _actManager.UpdateBalanceType(balanceType);

                }
            }
            catch (Exception ex)
            {
                return View("index", _actManager.FindAllBalanceTypes());
            }

            return View("index", _actManager.FindAllBalanceTypes());
        }
    }
}