using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ares.Infrastructure.Email
{
    public interface IEmailService
    {
        void SendEmail(string from, string to, string subject, string body);
    }
}
