using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares.Infrastructure.SMSNotification
{
    public interface IMessageNotification
    {
        void Send(string message);

    }
}
