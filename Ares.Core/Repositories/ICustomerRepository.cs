using Ares.Core.Domain;
using Ares.Core.Dto;

namespace Ares.Core.Repositories
{
    public interface ICustomerRepository:IRepository<Customer,int>
    {
        System.Collections.Generic.List<GetCustomerReturnModel> GetCustomer();
    }
}
