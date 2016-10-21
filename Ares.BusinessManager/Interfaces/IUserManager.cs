using Ares.Core.Domain;

namespace Ares.BusinessManager.Interfaces
{
    public interface IUserManager
    {
        Employee FindById(int employeeId);
    }
}
