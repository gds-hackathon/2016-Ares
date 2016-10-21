using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ares.Infrastructure.Email
{
    public class EmailServiceFactory
    {
        private static IEmailService mailService;

        public static void InitializeEmailServiceFactory(IEmailService emailService)
        {
            mailService = emailService;
        }

        public static IEmailService GetEmailService()
        {
            return mailService;
        }
    }
}
