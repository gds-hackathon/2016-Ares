using System;


namespace Ares.Infrastructure.Configuration
{
    public interface IApplicationSettings
    {
        string LoggerName { get; }

        string SMTP { get; }

        int Port { get; }

        string From { get; }

        string UserName { get; }

        string Password { get; }
    }
}
