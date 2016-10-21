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
        private IUserRoleRepository _userRoleRepository;
        private IRoleTypeRepository _roleTypeRepository;

        public AccountManager(
            IHashingService hashingService,
            ICustomerRepository customerRepository,
            IEmployeeRepository employeeRepository,
            IAdministratorRepository administratorRepository,
            IUserRoleRepository userRoleRepository,
            IRoleTypeRepository roleTypeRepository)
        {
            _customerRepository = customerRepository;
            _employeeRepository = employeeRepository;
            _administratorRepository = administratorRepository;
            _hashingService = hashingService;
            _userRoleRepository = userRoleRepository;
            _roleTypeRepository = roleTypeRepository;
        }

        public LoginResult Login(string userName, string password)
        {
            var loginResult = new LoginResult();
            var user = _userRoleRepository.FindAll(c => c.UserName == userName && c.Password == _hashingService.Hash(password)).FirstOrDefault();
            var role = _roleTypeRepository.FindAll(r => r.RoleId == user.RoleId).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("UserName or Password is invalid.");
            }
            else
            {
                loginResult.UserId = user.UserId;
                if (role != null)
                {
                    loginResult.RoleType = (RoleTypes)Enum.Parse(typeof(RoleTypes), role.RoleType_);
                }
            }

            return loginResult;
        }

        public void RegistryUser(string loginName, int? phoneNum, string password, string name, RoleTypes roleType)
        {
            // hash password
            var hashedPassword = _hashingService.Hash(password);

            // add to user table
            var userEntity = new UserRole()
            {
                UserName = loginName,
                Password = hashedPassword,
                PhoneNum = phoneNum
            };
            _userRoleRepository.Add(userEntity);

            switch (roleType)
            {
                case RoleTypes.Customer:
                    Customer customerEntity = new Customer()
                    {
                        CustomerName = name,
                        UserId = userEntity.UserId
                    };
                    _customerRepository.Add(customerEntity);
                    break;
                case RoleTypes.Employee:
                    Employee empEntity = new Employee()
                    {
                        EmployeeName = name,
                        UserId = userEntity.UserId
                    };
                    _employeeRepository.Add(empEntity);
                    break;
                default:
                    //
                    break;
            }

        }
    }
}
