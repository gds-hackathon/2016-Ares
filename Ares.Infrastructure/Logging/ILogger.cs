using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ares.Infrastructure.Logging
{
    public interface ILogger
    {
        void Log(string message);

        void Warn(string message);

        void Error(string message,System.Exception ex);
    }
}
