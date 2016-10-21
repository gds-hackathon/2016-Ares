using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;

namespace Ares.Infrastructure.Authentication
{
    public class AspFormsAuthentication:IFormsAuthentication
    {
        public void SetAuthenticationToken(string token, string role)
        {
            // FormsAuthentication.SetAuthCookie(token, false);
            SetAuthenticationTicket(token, false, role);
        }

        public string GetAuthenticationToken()
        {
            return HttpContext.Current.User.Identity.Name;
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
            HttpContext.Current.Session.Abandon();
        }


        private void SetAuthenticationTicket(string username, bool persist, string role)
        {
            HttpCookie authCookie = FormsAuthentication.GetAuthCookie(username, persist);
            FormsAuthenticationTicket tempTicket = FormsAuthentication.Decrypt(authCookie.Value);
            string userData = role;
            FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                    tempTicket.Version,
                    tempTicket.Name,
                    tempTicket.IssueDate,
                    tempTicket.Expiration,
                    persist,
                    userData,
                    tempTicket.CookiePath
                );
            authCookie.Value = FormsAuthentication.Encrypt(authTicket);
            authCookie.Name = FormsAuthentication.FormsCookieName;
            HttpContext.Current.Response.Cookies.Add(authCookie);
        }
    }
}
