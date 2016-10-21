using Ares.BusinessManager.Interfaces;
using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Infrastructure.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ares.Core.Repositories;

namespace Ares.BusinessManager.Implementation
{
    public class TransactionManager : ITransactionManager
    {
        private ITransactionRepository _transactionRepository;

        public TransactionManager(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        
        public IEnumerable<Transaction> FindTopTransactionByUser(int employeeId)
        {
            return _transactionRepository.FindAll(e => e.EmployeeId == employeeId && e.TransactionDateTime >= DateTime.Now.AddDays(-DateTime.Now.Day), "TransactionDateTime" ,0, 5);
        }

        public IEnumerable<Transaction> FindTransactionsHistory(int employeeId, int pageIndex, int pageSize)
        {
            return _transactionRepository.FindAll(e => e.EmployeeId == employeeId, "TransactionDateTime",pageIndex, pageSize);
        }

        public IEnumerable<Transaction> FindTransactionsHistoryByCustomer(int customerId, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
