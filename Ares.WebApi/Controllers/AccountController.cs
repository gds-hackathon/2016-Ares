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
    public class AccountController : BaseController
    {
        private IAccountManager _accountManager;
        private IUserManager _userManager;

        public AccountController()
        {

        }
        public AccountController(IAccountManager accountManager,IUserManager userManager)
        {
            _accountManager = accountManager;
            _userManager = userManager;
        }



        [Route("~/Restaurant/v1/Account/Login")]
        [HttpPost]
        public LoginResponse Login([FromBody]LoginRequest request)
        {
            LoginResponse response = new LoginResponse();
            try
            {

                if (request == null)
                {
                    response.ResponseMessage = "request is null";
                    response.Success = false;
                    return response;
                }   
                var result = _accountManager.EmployeeLogin(request.UserName, request.Password);
                if (result.RoleType == Core.Domain.RoleTypes.Employee)
                {
                    Employee employee = _userManager.FindById(result.UserId);
                    if (employee != null)
                    {
                        response.NickName = employee.EmployeeName;
                        response.Count = 0;
                        response.Balance = 0;
                       
                    }
                }
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {

                response.Success = false;
                response.ResponseMessage = ex.Message;
            }
            return response;
            
        }


    }
}
