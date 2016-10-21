using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Data.Ef.Repositories;
using Ares.BusinessManager.Interfaces;

namespace Ares.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // Repositories
            container.RegisterType<IAdministratorRepository, AdministratorRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IUserRoleRepository, UserRoleRepository>();
            container.RegisterType<IBalanceTypeRepository, BalanceTypeRepository>();
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<IRoleTypeRepository, RoleTypeRepository>();

            //Business manager



            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}