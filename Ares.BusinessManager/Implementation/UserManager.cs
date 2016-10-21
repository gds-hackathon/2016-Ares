using Ares.BusinessManager.Interfaces;
using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Infrastructure.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares.BusinessManager.Implementation
{
    public class UserManager : IUserManager
    {
        private IEmployeeRepository _employeeRepository;
        private ICustomerRepository _customerRepository;

        public UserManager(
            IEmployeeRepository employeeRepository,
            ICustomerRepository customerRepository)
        {
            _employeeRepository = employeeRepository;
            _customerRepository = customerRepository;
        }
        public Employee FindById(int employeeId)
        {
            return _employeeRepository.FindAll(e => e.UserId == employeeId).FirstOrDefault();
        }

        public Customer GetCustomerByUserId(int userId)
        {
            return _customerRepository.FindAll(e => e.UserId == userId).FirstOrDefault();
        }

        public Employee GetEmployeeByUserId(int userId)
        {
            return _employeeRepository.FindAll(e => e.UserId == userId).FirstOrDefault();
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.Save(customer);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.Save(employee);
        }

        public IEnumerable<Employee> FindAllEmployees()
        {
            return _employeeRepository.FindAll();
        }

        public IEnumerable<Customer> FindAllCustomers()
        {
            return _customerRepository.FindAll();
        }
    }
}
