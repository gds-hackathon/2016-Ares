using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ares.BusinessManager.Interfaces;
using Ares.Contract.Request;
using Ares.Contract.Response;

namespace Ares.WebApi.Controllers
{
    public class AccountController : BaseController
    {
        private IAccountManager _accountManager;

        public AccountController()
        {

        }
        public AccountController(IAccountManager accountManager)
        {
            _accountManager = accountManager;
        }



        [Route("~/Restaurant/v1/Login")]
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
                _accountManager.Login(request.UserName, request.Password);
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
