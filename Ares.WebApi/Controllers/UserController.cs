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
    public class UserController : BaseController
    {
        private IUserManager _userManager;
        public UserController()
        {

        }

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [Route("~/Restaurant/v1/User/Employee/{employeeId}")]
        [HttpGet]
        public EmployeeResponse GetEmployee([FromUri]int employeeId)
        {
            EmployeeResponse response = new EmployeeResponse();
            var employee = _userManager.FindByEmployeeId(employeeId);
            response.Success = true;
            response.EmployeeId = employee.EmployeeId;
            response.NickName = employee.EmployeeName;
            response.Gender = employee.Gender;
            response.Balance = 0;
            response.Count = 0;
            return response;
        }


    }
}
