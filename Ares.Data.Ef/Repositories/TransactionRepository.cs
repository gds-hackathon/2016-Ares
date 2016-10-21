using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Data.Ef.UnitOfWork;


namespace Ares.Data.Ef.Repositories
{
    public class TransactionRepository: Repository<Transaction, int>, ITransactionRepository
    {
        public TransactionRepository(IUnitOfWork unitOfWork)
          : base(unitOfWork)
        {

        }
    }
}
