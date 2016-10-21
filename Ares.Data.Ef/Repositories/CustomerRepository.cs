using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Data.Ef.UnitOfWork;

namespace Ares.Data.Ef.Repositories
{
   public class CustomerRepository:Repository<Customer,int>,ICustomerRepository
    {
        public CustomerRepository(IUnitOfWork unitOfWork)
          : base(unitOfWork)
        {

        }
    }
}
