using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Config;
using Ares.Infrastructure.Configuration;

namespace Ares.Infrastructure.Logging
{
    public class Log4NetAdapter : ILogger
    {
        private readonly log4net.ILog log;

        public Log4NetAdapter()
        {
            XmlConfigurator.Configure();
            this.log = LogManager
             .GetLogger(ApplicationSettingsFactory.GetApplicationSettings().LoggerName);
        }


        public void Log(string message)
        {
            this.log.Info(message);
        }

        public void Warn(string message)
        {
            this.log.Warn(message);
        }


        public void Error(string message, System.Exception ex)
        {
            this.log.Error(message, ex);
        }
    }
}
