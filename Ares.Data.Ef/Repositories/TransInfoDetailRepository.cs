using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Data.Ef.UnitOfWork;

namespace Ares.Data.Ef.Repositories
{
    public class TransInfoDetailRepository:Repository<TransInfoDetail,int>,ITransInfoDetailRepository
    {
        public TransInfoDetailRepository(IUnitOfWork unitOfWork)
          : base(unitOfWork)
        {

        }
    }
}
