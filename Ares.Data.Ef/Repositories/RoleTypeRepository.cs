using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Data.Ef.UnitOfWork;

namespace Ares.Data.Ef.Repositories
{
    public class RoleTypeRepository:Repository<RoleType,int>,IRoleTypeRepository
    {
        public RoleTypeRepository(IUnitOfWork unitOfWork)
          : base(unitOfWork)
        {

        }
    }
}
