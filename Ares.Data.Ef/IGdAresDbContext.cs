using Ares.Core.Domain;

namespace Ares.Data.Ef
{
    public interface IGdAresDbContext
    {
        System.Data.Entity.DbSet<Administrator> Administrators { get; set; } // Administrator
        System.Data.Entity.DbSet<BalanceType> BalanceTypes { get; set; } // BalanceType
        System.Data.Entity.DbSet<Customer> Customers { get; set; } // Customer
        System.Data.Entity.DbSet<Employee> Employees { get; set; } // Employee
        System.Data.Entity.DbSet<RoleType> RoleTypes { get; set; } // RoleType
        System.Data.Entity.DbSet<UserRole> UserRoles { get; set; } // UserRole

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);

      
        
    }
}
