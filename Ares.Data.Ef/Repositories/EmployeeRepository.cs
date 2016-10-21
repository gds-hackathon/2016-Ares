using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Data.Ef.UnitOfWork;

namespace Ares.Data.Ef.Repositories
{
    public class EmployeeRepository:Repository<Employee,int>,IEmployeeRepository
    {
        public EmployeeRepository(IUnitOfWork unitOfWork)
          : base(unitOfWork)
        {

        }
    }
}
