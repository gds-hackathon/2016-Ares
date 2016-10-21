using Ares.Core.Domain;
using System.Collections.Generic;

namespace Ares.BusinessManager.Interfaces
{
    public interface IUserManager
    {
        Employee FindById(int employeeId);

        Employee GetEmployeeByUserId(int userId);

        Customer GetCustomerByUserId(int userId);

        void UpdateCustomer(Customer customer);

        void UpdateEmployee(Employee employee);

        IEnumerable<Employee> FindAllEmployees();
        IEnumerable<Customer> FindAllCustomers();
    }
}
