using Ares.BusinessManager.Interfaces;
using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Infrastructure.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ares.Core.Dto;

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

        public IEnumerable<GetCustomerReturnModel> FindCustomerList()
        {
            return _customerRepository.GetCustomer();
        }

        public Employee FindByEmployeeId(int employeeId)
        {
            return _employeeRepository.FindBy(employeeId);
        }

        public Customer ValidateCustomer(string qrCode)
        {
            if (string.IsNullOrWhiteSpace(qrCode))
            {
                throw new ArgumentNullException("qrCode");
            }
            Guid code = Guid.Parse(qrCode);
            return _customerRepository.FindAll(c => c.Guid == code).FirstOrDefault();
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

        public Customer FindByCustomerId(int customerId)
        {
            return _customerRepository.FindAll(c => c.CustomerId == customerId).FirstOrDefault();
        }
    }
}
