using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ares.BusinessManager.Interfaces;
using Ares.Contract.Request;
using Ares.Contract.Response;
using Ares.Core.Domain;

namespace Ares.WebApi.Controllers
{
    public class TransactionController : BaseController
    {
        private ITransactionManager _transactionManager;

        public TransactionController()
        {

        }

        public TransactionController(ITransactionManager transactionManager)
        {
            _transactionManager = transactionManager;

        }

        [Route("~/Restaurant/v1/Transaction/ConsumInfo")]
        [HttpGet]
        public ConsumInfoResponse ConsumInfo(int employeeId)
        {
            ConsumInfoResponse response = new ConsumInfoResponse();

            var result = _transactionManager.FindEmployeeTransactionSummary(employeeId);

            if (result != null)
            {
                response.ResultSet1 = result.ResultSet1.Select(c => new ResultSetModel1
                {
                    CustomerID = c.CustomerID,
                    CustomerName = c.CustomerName,
                    DiscountAmount = c.DiscountAmount,
                    TotalAmount = c.TotalAmount,
                    TransCount = c.TransCount
                }).ToList();

                response.ResultSet2 = result.ResultSet2.Select(c => new ResultSetModel2
                {
                    CurrentBalance = c.CurrentBalance,
                    DiscountAmount = c.DiscountAmount,
                    TotalAmount = c.TotalAmount,
                    TransCount = c.TransCount
                }).ToList();
            }
         

            response.Success = true;
            return response;
        }
        
        



    }
}
