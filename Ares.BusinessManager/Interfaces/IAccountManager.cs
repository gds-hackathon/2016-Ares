using Ares.Core.Domain;

namespace Ares.BusinessManager.Interfaces
{
    public interface IAccountManager
    {
        LoginResult Login(string userName, string password);
        LoginResult EmployeeLogin(string userName, string password);
        LoginResult LoginByPhoneNum(string phoneNum, string password);
        void RegistryUser(string loginName, string phoneNum, string password, string name, RoleTypes roleType);
        void ChangePassword(int userId, string oldPassword, string newPassword);
    }
}
