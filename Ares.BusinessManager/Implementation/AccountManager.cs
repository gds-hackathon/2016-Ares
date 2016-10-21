using Ares.BusinessManager.Interfaces;
using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Infrastructure.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ares.Infrastructure.Authentication;

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
        private IFormsAuthentication _formsAuthentication;
        private IBalanceTypeRepository _balanceTypeRepository;

        public AccountManager(
            IHashingService hashingService,
            ICustomerRepository customerRepository,
            IEmployeeRepository employeeRepository,
            IAdministratorRepository administratorRepository,
            IUserRoleRepository userRoleRepository,
            IRoleTypeRepository roleTypeRepository,
            IFormsAuthentication formsAuthentication,
            IBalanceTypeRepository balanceType)
        {
            _customerRepository = customerRepository;
            _employeeRepository = employeeRepository;
            _administratorRepository = administratorRepository;
            _hashingService = hashingService;
            _userRoleRepository = userRoleRepository;
            _roleTypeRepository = roleTypeRepository;
            _formsAuthentication = formsAuthentication;
            _balanceTypeRepository = balanceType;
        }

        public LoginResult Login(string userName, string password)
        {
            var loginResult = new LoginResult();
            var hashedPsd = _hashingService.Hash(password);
            var user = _userRoleRepository.FindAll(c => c.UserName == userName && c.Password == hashedPsd).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("PhoneNumber or Password is invalid.");
            }
            else
            {
                var role = _roleTypeRepository.FindAll(r => r.RoleId == user.RoleId).FirstOrDefault();

                loginResult.UserId = user.UserId;
                if (role != null)
                {
                    loginResult.RoleType = (RoleTypes)Enum.Parse(typeof(RoleTypes), role.RoleType_);
                    switch (loginResult.RoleType)
                    {
                        case RoleTypes.Customer:
                            _formsAuthentication.SetAuthenticationToken(user.UserId.ToString(), "Customer");
                            break;
                        case RoleTypes.Employee:
                            throw new Exception("Employee can not login this service.");
                        //_formsAuthentication.SetAuthenticationToken(user.UserId.ToString(), "Employee");
                        //break;
                        case RoleTypes.Administrator:
                            _formsAuthentication.SetAuthenticationToken(user.UserId.ToString(), "Administrator");
                            break;
                        default:
                            break;
                    }
                }

            }

            return loginResult;
        }

        public void RegistryUser(string loginName, string phoneNum, string password, string name, RoleTypes roleType)
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

        public LoginResult LoginByPhoneNum(string phoneNum, string password)
        {
            var loginResult = new LoginResult();
            var hashedPsd = _hashingService.Hash(password);
            var user = _userRoleRepository.FindAll(c => c.PhoneNum == phoneNum && c.Password == hashedPsd).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("UserName or Password is invalid.");
            }
            else
            {
                var role = _roleTypeRepository.FindAll(r => r.RoleId == user.RoleId).FirstOrDefault();

                loginResult.UserId = user.UserId;
                if (role != null)
                {
                    loginResult.RoleType = (RoleTypes)Enum.Parse(typeof(RoleTypes), role.RoleType_);
                    switch (loginResult.RoleType)
                    {
                        case RoleTypes.Customer:
                            _formsAuthentication.SetAuthenticationToken(user.UserId.ToString(), "Customer");
                            break;
                        case RoleTypes.Employee:
                            throw new Exception("Employee can not login this service.");
                        //_formsAuthentication.SetAuthenticationToken(user.UserId.ToString(), "Employee");
                        //break;
                        case RoleTypes.Administrator:
                            _formsAuthentication.SetAuthenticationToken(user.UserId.ToString(), "Administrator");
                            break;
                        default:
                            break;
                    }
                }

            }

            return loginResult;
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            var hashedPsd = _hashingService.Hash(oldPassword);
            var user = _userRoleRepository.FindAll(c => c.UserId == userId && c.Password == hashedPsd).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("No user or Password is invalid.");
            }
            else
            {
                user.Password = _hashingService.Hash(newPassword);
                _userRoleRepository.Save(user);
            }
        }

        public LoginResult EmployeeLogin(string userName, string password)
        {
            var loginResult = new LoginResult();
            var hashedPsd = _hashingService.Hash(password);
            var user = _userRoleRepository.FindAll(c => c.UserName == userName && c.Password == hashedPsd).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("PhoneNumber or Password is invalid.");
            }
            else
            {
                var role = _roleTypeRepository.FindAll(r => r.RoleId == user.RoleId).FirstOrDefault();

                loginResult.UserId = user.UserId;
                if (role != null)
                {
                    loginResult.RoleType = (RoleTypes)Enum.Parse(typeof(RoleTypes), role.RoleType_);
                    switch (loginResult.RoleType)
                    {
                        case RoleTypes.Customer:
                            _formsAuthentication.SetAuthenticationToken(user.UserId.ToString(), "Customer");
                            break;
                        case RoleTypes.Employee:
                            _formsAuthentication.SetAuthenticationToken(user.UserId.ToString(), "Employee");
                            break;
                        case RoleTypes.Administrator:
                            _formsAuthentication.SetAuthenticationToken(user.UserId.ToString(), "Administrator");
                            break;
                        default:
                            break;
                    }
                }

            }

            return loginResult;
        }

        public void UpdateBalanceType(BalanceType balanceType)
        {
            if (_balanceTypeRepository.FindAll(b => b.BalanceTypeId == balanceType.BalanceTypeId).FirstOrDefault() == null)
            {
                throw new Exception("No related Balance ID");
            }

            _balanceTypeRepository.Save(balanceType);
        }

        public void AddBalanceType(BalanceType newBalanceType)
        {
            _balanceTypeRepository.Add(newBalanceType);
        }

        public BalanceType GetBalanceType(int balanceTypeId)
        {
            return _balanceTypeRepository.FindAll(f => f.BalanceTypeId == balanceTypeId).FirstOrDefault();
        }

        public IEnumerable<BalanceType> FindAllBalanceTypes()
        {
            return _balanceTypeRepository.FindAll();
        }
    }
}
