using Ares.Core.Domain;
using Ares.Core.Dto;
using System.Collections.Generic;

namespace Ares.BusinessManager.Interfaces
{
    public interface IUserManager
    {
        Employee FindById(int employeeId);

        Employee GetEmployeeByUserId(int userId);

        Customer GetCustomerByUserId(int userId);

        Employee FindByEmployeeId(int employeeId);

        IEnumerable<GetCustomerReturnModel> FindCustomerList();
    }
}
