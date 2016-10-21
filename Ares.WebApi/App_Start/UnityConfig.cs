using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Data.Ef.Repositories;
using Ares.BusinessManager.Interfaces;
using Ares.BusinessManager.Implementation;
using Ares.Infrastructure.Security;
using Ares.Infrastructure.Authentication;
using Ares.Infrastructure.Logging;
using Ares.Data.Ef.UnitOfWork;
using Ares.Data.Ef;

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
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IDbContext, GdAresDbContext>();
            container.RegisterType<IGdAresDbContext, GdAresDbContext>();
            container.RegisterType<IAdministratorRepository, AdministratorRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IUserRoleRepository, UserRoleRepository>();
            container.RegisterType<IBalanceTypeRepository, BalanceTypeRepository>();
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<IRoleTypeRepository, RoleTypeRepository>();

            // Business manager
            container.RegisterType<IAccountManager, AccountManager>();

            // Infrastructure
            container.RegisterType<IHashingService, DefaultPasswordHasher>();
            container.RegisterType<IFormsAuthentication, AspFormsAuthentication>();
            container.RegisterType<IHashingService, DefaultPasswordHasher>();
            container.RegisterType<ILogger, Log4NetAdapter>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}