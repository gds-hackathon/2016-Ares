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
    public class AccountManager : IAccountManager
    {
        private ICustomerRepository _customerRepository;
        private IEmployeeRepository _employeeRepository;
        private IAdministratorRepository _administratorRepository;
        private IHashingService _hashingService;

        public AccountManager(
            IHashingService hashingService,
            ICustomerRepository customerRepository,
            IEmployeeRepository employeeRepository,
            IAdministratorRepository administratorRepository)
        {
            _customerRepository = customerRepository;
            _employeeRepository = employeeRepository;
            _administratorRepository = administratorRepository;
            _hashingService = hashingService;
        }

        public void Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public void RegistryUser(string userName, string password, RoleTypes roleType)
        {
            // hash password
            var hashedPassword = _hashingService.Hash(password);

            // add to user table


            switch (roleType)
            {
                case RoleTypes.Customer:
                    Customer customerEntity = new Customer()
                    {
                    };
                    _customerRepository.Add(customerEntity);
                    break;
                case RoleTypes.Employee:
                    Employee empEntity = new Employee() { };
                    _employeeRepository.Add(empEntity);
                    break;
                default:
                    break;
            }
        }
    }
}
