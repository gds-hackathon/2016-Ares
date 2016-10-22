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
using Ares.Core;

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
        public ConsumInfoResponse ConsumInfo([FromUri]int employeeId)
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

        [Route("~/Restaurant/v1/Transaction/CalculateDiscount")]
        [HttpPost]
        public CalculateDiscountResponse CalculateDiscount([FromBody]CalculateDiscountRequest request)
        {
            CalculateDiscountResponse response = new CalculateDiscountResponse();
            if (request == null)
            {
                response.Success = false;
            }
            int? transactionId = 0;
            var realPay = _transactionManager.CalculateDiscount(request.EmployeeId, request.CustomerId, request.TotalAmount,out transactionId);
            response.TransactionId = transactionId.HasValue ? transactionId.Value:0;
            response.Success = true;
            response.RealPay = realPay;
            return response;
        }

        [Route("~/Restaurant/v1/Transaction/SetSuccess")]
        [HttpPost]
        public void UpdateTransactionStatus(int transactionId)
        {

        }

        [Route("~/Restaurant/v1/Transaction/CustomerTransRatingList")]
        [HttpGet]
        public IEnumerable<TransactionRatingResponse> GetTransactionRatingListByCusId(int customerId)
        {
            List<TransactionRatingResponse> response = new List<TransactionRatingResponse>();

            var result =  _transactionManager.GetTransInfoDetailByCusId(customerId).Select(c=>new TransactionRatingResponse
            {
                Comment = c.FeedBack,
                CustomerName = c.CustomerName,
                EmployeeName = c.EmployeeName,
                Score = Convert.ToInt32(c.RateLevel)
            }).ToList();
            return result;
        }

        [Route("~/Restaurant/v1/Transaction/EmployeeTransRatingList")]
        [HttpGet]
        public IEnumerable<TransactionRatingResponse> GetTransactionRatingListByEmployeeId(int employeeId)
        {
            List<TransactionRatingResponse> response = new List<TransactionRatingResponse>();

            var result = _transactionManager.GetTransInfoDetailByEmployeeId(employeeId).Select(c => new TransactionRatingResponse
            {
                Comment = c.FeedBack,
                CustomerName = c.CustomerName,
                EmployeeName = c.EmployeeName,
                Score = Convert.ToInt32(c.RateLevel)
            }).ToList();
            return result;
        }


    }
}
