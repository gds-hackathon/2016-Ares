using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Data.Ef.UnitOfWork;

namespace Ares.Data.Ef.Repositories
{
    public class AdministratorRepository:Repository<Administrator,int>,IAdministratorRepository
    {
        public AdministratorRepository(IUnitOfWork unitOfWork)
          : base(unitOfWork)
        {

        }
    }
}
