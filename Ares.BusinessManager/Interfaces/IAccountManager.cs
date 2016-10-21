using Ares.Core.Domain;
using System.Collections.Generic;

namespace Ares.BusinessManager.Interfaces
{
    public interface IAccountManager
    {
        LoginResult Login(string userName, string password);
        LoginResult EmployeeLogin(string userName, string password);
        LoginResult LoginByPhoneNum(string phoneNum, string password);
        void RegistryUser(string loginName, string phoneNum, string password, string name, RoleTypes roleType);
        void ChangePassword(int userId, string oldPassword, string newPassword);

        void UpdateBalanceType(BalanceType balanceType);
        void AddBalanceType(BalanceType newBalanceType);

        BalanceType GetBalanceType(int balanceTypeId);

        IEnumerable<BalanceType> FindAllBalanceTypes();
    }
}
