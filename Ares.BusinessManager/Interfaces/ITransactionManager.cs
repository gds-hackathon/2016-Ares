using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ares.Core.Domain;

namespace Ares.BusinessManager.Interfaces
{
    public interface ITransactionManager
    {
        IEnumerable<Transaction> FindTopTransactionByUser(int employeeId);

        IEnumerable<Transaction> FindTransactionsHistory(int employeeId,int pageIndex,int pageSize);

        IEnumerable<Transaction> FindTransactionsHistoryByCustomer(int customerId, int pageIndex, int pageSize);

    }
}
