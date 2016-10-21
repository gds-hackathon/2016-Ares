using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Data.Ef.Repositories;
using Ares.Infrastructure.Security;
using Ares.BusinessManager.Interfaces;
using Ares.BusinessManager.Implementation;
using Ares.Data.Ef.UnitOfWork;
using Ares.Data.Ef;
using Ares.Infrastructure.Authentication;

namespace Ares.Web.Admin
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // Repositories
            container.RegisterType<IAdministratorRepository, AdministratorRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IUserRoleRepository, UserRoleRepository>();
            container.RegisterType<IBalanceTypeRepository, BalanceTypeRepository>();
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<IRoleTypeRepository, RoleTypeRepository>();
            container.RegisterType<IHashingService, DefaultPasswordHasher>();
            container.RegisterType<IAccountManager, AccountManager>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IDbContext, GdAresDbContext>();
            container.RegisterType<IUserRoleRepository, UserRoleRepository>();
            container.RegisterType<IRoleTypeRepository, RoleTypeRepository>();
            container.RegisterType<IUserManager, UserManager>();
            container.RegisterType<IFormsAuthentication, AspFormsAuthentication>();
            container.RegisterType<ITransactionManager, TransactionManager>();
        }
    }
}
