using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Data.Ef.UnitOfWork;

namespace Ares.Data.Ef.Repositories
{
   public class BalanceTypeRepository:Repository<BalanceType,int>,IBalanceTypeRepository
    {
        public BalanceTypeRepository(IUnitOfWork unitOfWork)
          : base(unitOfWork)
        {

        }
    }
}
