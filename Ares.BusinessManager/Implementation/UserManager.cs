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

        public UserManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public Employee FindById(int employeeId)
        {
            return _employeeRepository.FindAll(e => e.UserId == employeeId).FirstOrDefault();
        }
    }
}
