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
                CustomerName = e.CustomerName,
                Discount = e.DiscountRating,
                Rating = e.RateLevel.Value,
                Address = e.Address,
                Success = true             
            
            });

            return list;


        }
    }
}
