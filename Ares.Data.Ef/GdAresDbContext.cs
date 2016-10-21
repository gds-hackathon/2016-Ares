using System.Linq;
using Ares.Core.Domain;
using Ares.Data.Ef.Mapping;
using Ares.Data.Ef.UnitOfWork;

namespace Ares.Data.Ef
{
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public class GdAresDbContext: System.Data.Entity.DbContext, IGdAresDbContext, IDbContext
    {
        static GdAresDbContext()
        {
            System.Data.Entity.Database.SetInitializer<GdAresDbContext>(null);
        }

        public GdAresDbContext()
            : base("Name=GDAres")
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }



        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AdministratorMapping());
            modelBuilder.Configurations.Add(new BalanceTypeMapping());
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new EmployeeMapping());
            modelBuilder.Configurations.Add(new RoleTypeMapping());
            modelBuilder.Configurations.Add(new UserRoleMapping());
            modelBuilder.Configurations.Add(new TransactionMapping());
            modelBuilder.Configurations.Add(new TransactionRatingMapping());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AdministratorMapping(schema));
            modelBuilder.Configurations.Add(new BalanceTypeMapping(schema));
            modelBuilder.Configurations.Add(new CustomerMapping(schema));
            modelBuilder.Configurations.Add(new EmployeeMapping(schema));
            modelBuilder.Configurations.Add(new RoleTypeMapping(schema));
            modelBuilder.Configurations.Add(new TransactionMapping(schema));
            modelBuilder.Configurations.Add(new UserRoleMapping(schema));
            modelBuilder.Configurations.Add(new TransactionRatingMapping(schema));
            return modelBuilder;
        }
        public System.Linq.IQueryable<T> Find<T>() where T : class
        {
            return this.Set<T>();
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        public System.Data.Entity.DbSet<Administrator> Administrators { get; set; } // Administrator
        public System.Data.Entity.DbSet<BalanceType> BalanceTypes { get; set; } // BalanceType
        public System.Data.Entity.DbSet<Customer> Customers { get; set; } // Customer
        public System.Data.Entity.DbSet<Employee> Employees { get; set; } // Employee
        public System.Data.Entity.DbSet<RoleType> RoleTypes { get; set; } // RoleType
        public System.Data.Entity.DbSet<UserRole> UserRoles { get; set; } // UserRole
        public System.Data.Entity.DbSet<Transaction> Transactions { get; set; } // Transaction

    }
}
