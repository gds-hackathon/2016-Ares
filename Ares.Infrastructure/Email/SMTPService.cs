using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using Ares.Infrastructure.Configuration;
using Ares.Infrastructure.Logging;

namespace Ares.Infrastructure.Email
{
    public class SMTPService : IEmailService
    {
        public void SendEmail(string from, string to, string subject, string body)
        {
            try
            {
                MailMessage message = new MailMessage(ApplicationSettingsFactory.GetApplicationSettings().From, to);
                message.From = new MailAddress(ApplicationSettingsFactory.GetApplicationSettings().From);

                string[] toArraty = to.Split(';');
                MailAddressCollection addressCollection = new MailAddressCollection();
                foreach (var item in toArraty)
                {
                    MailAddress address = new MailAddress(item);
                    addressCollection.Add(address);
                }
                //message.To.Add(new MailAddress(to));
                message.To.Add(to);
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = ApplicationSettingsFactory.GetApplicationSettings().SMTP;
                smtp.Port = ApplicationSettingsFactory.GetApplicationSettings().Port;
                smtp.UseDefaultCredentials = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                string userName = ApplicationSettingsFactory.GetApplicationSettings().UserName;
                string password = ApplicationSettingsFactory.GetApplicationSettings().Password;
                smtp.Credentials = new System.Net.NetworkCredential(userName, password);
                smtp.Send(message);
            }
            catch (System.Exception ex)
            {
                LoggingFactory.GetLogger().Error(ex.Message,ex);
                throw;
            }

        }
    }
}
