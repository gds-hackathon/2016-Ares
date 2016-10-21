using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Data.Ef.UnitOfWork;

namespace Ares.Data.Ef.Repositories
{
   public class UserRoleRepository:Repository<UserRole,int>,IUserRoleRepository
    {
        public UserRoleRepository(IUnitOfWork unitOfWork)
          : base(unitOfWork)
        {

        }

    }
}
