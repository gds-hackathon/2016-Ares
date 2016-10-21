using System;

namespace Ares.Infrastructure.Authentication
{
    public interface IFormsAuthentication
    {
        void SetAuthenticationToken(string token, string role);

        string GetAuthenticationToken();

        void SignOut();
    }
}
