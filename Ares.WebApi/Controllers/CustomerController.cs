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
    public class CustomerController : BaseController
    {
        private IUserManager _userManaget;

        public CustomerController()
        {

        }

        public CustomerController(IUserManager userManager)
        {
            _userManaget = userManager;
        }

        [Route("~/Restaurant/v1/Customer/List")]
        [HttpGet]
        public IEnumerable<CusomerListResponse> GetCustomerList()
        {
            IEnumerable<CusomerListResponse> list = _userManaget.FindCustomerList().Select(e => new CusomerListResponse
            {
                CustomerID = e.CustomerID,
                CustomerName = e.CustomerName,
                Discount = e.DiscountRating,
                DiscountRating = e.RateLevel.Value,
                Address = e.Address,
                Success = true

            });

            return list;


        }

        [Route("~/Restaurant/v1/Customer/Verify")]
        [HttpPost]
        public CustomerValidateResponse IsValidateCustomer([FromBody]CustomerValidateRequest request)
        {
            CustomerValidateResponse response = new CustomerValidateResponse();
            if (request == null)
            {
                response.Success = false;
                response.IsValidate = false;

            }
            var customer = _userManaget.ValidateCustomer(request.QRCode);
            response.CustomerId = customer.CustomerId;
            response.IsValidate = true;
            response.Success = true;
            return response;
        }

        [Route("~/Restaurant/v1/Customer/Detail")]
        [HttpGet]
        public CustomerResponse Customer([FromUri]CustomerRequest request)
        {
            CustomerResponse response = new CustomerResponse();
            if (request == null)
            {
                response.Success = false;
                return response;
            }
            var customer = _userManaget.FindByCustomerId(request.CustomerId);
            response.CustomerName = customer.CustomerName;
            response.DiscountRating = customer.DiscountRating;
            response.Address = customer.Address;
            return response;
        }

        
    }
}
