using System;
using System.Configuration;

namespace Ares.Infrastructure.Configuration
{
    public class WebConfigApplicationSettings : IApplicationSettings
    {
        public string LoggerName
        {
            get { return ConfigurationManager.AppSettings["LoggerName"]; }
        }

        public string SMTP
        {
            get { return ConfigurationManager.AppSettings["SMTP"]; }
        }

        public int Port
        {
            get { return int.Parse(ConfigurationManager.AppSettings["Port"]); }
        }

        public string From
        {
            get { return ConfigurationManager.AppSettings["From"]; }
        }

        public string UserName
        {
            get { return ConfigurationManager.AppSettings["UserName"]; }
        }

        public string Password
        {
            get { return ConfigurationManager.AppSettings["Password"]; }
        }

    }
}
