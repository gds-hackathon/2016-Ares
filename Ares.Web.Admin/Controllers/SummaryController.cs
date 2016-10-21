using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ares.Core.Domain;
using Ares.Core.Dto;
using Ares.Core.Repositories;
using Ares.BusinessManager.Interfaces;

namespace Ares.Web.Admin.Controllers
{
    public class SummaryController : BaseController
    {
        private ITransactionManager _transactionManager;

        public SummaryController()
        {

        }

        public SummaryController(ITransactionManager transactionManager)
        {
            _transactionManager = transactionManager;
        }

     

    }
}