

using Ares.Core.Domain;

namespace Ares.BusinessManager.Interfaces
{
    public interface IAccountManager
    {
        void Login(string userName, string password);
        void RegistryUser(string loginName, int? phoneNum, string password, string name, RoleTypes roleType);
    }
}
