// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.61
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace Ares.CodeGeneration
{

    public interface IGdAresDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<Administrator> Administrators { get; set; } // Administrator
        System.Data.Entity.DbSet<BalanceType> BalanceTypes { get; set; } // BalanceType
        System.Data.Entity.DbSet<Customer> Customers { get; set; } // Customer
        System.Data.Entity.DbSet<Employee> Employees { get; set; } // Employee
        System.Data.Entity.DbSet<RoleType> RoleTypes { get; set; } // RoleType
        System.Data.Entity.DbSet<sys_DatabaseFirewallRule> sys_DatabaseFirewallRules { get; set; } // database_firewall_rules
        System.Data.Entity.DbSet<sys_ScriptDeployment> sys_ScriptDeployments { get; set; } // script_deployments
        System.Data.Entity.DbSet<sys_ScriptDeploymentStatus> sys_ScriptDeploymentStatus { get; set; } // script_deployment_status
        System.Data.Entity.DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        System.Data.Entity.DbSet<Transaction> Transactions { get; set; } // Transactions
        System.Data.Entity.DbSet<TransactionRating> TransactionRatings { get; set; } // TransactionRating
        System.Data.Entity.DbSet<UserRole> UserRoles { get; set; } // UserRole

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);

        // Stored Procedures
        int AddNewAdmin(string adminName, string password, string userName, string phoneNum);
        // AddNewAdminAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int AddNewCustomer(string customerName, int? discountRating, byte[] discountPicture, string password, string userName, string phoneNum, string address);
        // AddNewCustomerAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        System.Collections.Generic.List<AddNewEmployeeReturnModel> AddNewEmployee(int? employeeId, string employeeName, int? balance, string password, string userName, string phoneNum);
        System.Collections.Generic.List<AddNewEmployeeReturnModel> AddNewEmployee(int? employeeId, string employeeName, int? balance, string password, string userName, string phoneNum, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<AddNewEmployeeReturnModel>> AddNewEmployeeAsync(int? employeeId, string employeeName, int? balance, string password, string userName, string phoneNum);

        int CalculateDiscount(int? employeeId, int? customerId, decimal? totalAmount, out decimal? realPay, out int? transactionId);
        // CalculateDiscountAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        System.Collections.Generic.List<CheckTransactionByCustomerIdReturnModel> CheckTransactionByCustomerId(int? customerId);
        System.Collections.Generic.List<CheckTransactionByCustomerIdReturnModel> CheckTransactionByCustomerId(int? customerId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<CheckTransactionByCustomerIdReturnModel>> CheckTransactionByCustomerIdAsync(int? customerId);

        System.Collections.Generic.List<CheckTransactionByEmpIdReturnModel> CheckTransactionByEmpId(int? employeeId);
        System.Collections.Generic.List<CheckTransactionByEmpIdReturnModel> CheckTransactionByEmpId(int? employeeId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<CheckTransactionByEmpIdReturnModel>> CheckTransactionByEmpIdAsync(int? employeeId);

        CountTransactionByEmpIdReturnModel CountTransactionByEmpId(int? employeeId);
        System.Threading.Tasks.Task<CountTransactionByEmpIdReturnModel> CountTransactionByEmpIdAsync(int? employeeId);

        System.Collections.Generic.List<GetCustomerReturnModel> GetCustomer();
        System.Collections.Generic.List<GetCustomerReturnModel> GetCustomer(out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<GetCustomerReturnModel>> GetCustomerAsync();

        System.Collections.Generic.List<LoginCheckReturnModel> LoginCheck(string userName, string phoneNum, string password);
        System.Collections.Generic.List<LoginCheckReturnModel> LoginCheck(string userName, string phoneNum, string password, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<LoginCheckReturnModel>> LoginCheckAsync(string userName, string phoneNum, string password);

        SettlementForCustomerReturnModel SettlementForCustomer(System.DateTime? startDate, System.DateTime? endDate);
        System.Threading.Tasks.Task<SettlementForCustomerReturnModel> SettlementForCustomerAsync(System.DateTime? startDate, System.DateTime? endDate);

        int SpAlterdiagram(string diagramname, int? ownerId, int? version, byte[] definition);
        // SpAlterdiagramAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int SpCreatediagram(string diagramname, int? ownerId, int? version, byte[] definition);
        // SpCreatediagramAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int SpDropdiagram(string diagramname, int? ownerId);
        // SpDropdiagramAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        System.Collections.Generic.List<SpHelpdiagramdefinitionReturnModel> SpHelpdiagramdefinition(string diagramname, int? ownerId);
        System.Collections.Generic.List<SpHelpdiagramdefinitionReturnModel> SpHelpdiagramdefinition(string diagramname, int? ownerId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<SpHelpdiagramdefinitionReturnModel>> SpHelpdiagramdefinitionAsync(string diagramname, int? ownerId);

        System.Collections.Generic.List<SpHelpdiagramsReturnModel> SpHelpdiagrams(string diagramname, int? ownerId);
        System.Collections.Generic.List<SpHelpdiagramsReturnModel> SpHelpdiagrams(string diagramname, int? ownerId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<SpHelpdiagramsReturnModel>> SpHelpdiagramsAsync(string diagramname, int? ownerId);

        int SpRenamediagram(string diagramname, int? ownerId, string newDiagramname);
        // SpRenamediagramAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int SpUpgraddiagrams();
        // SpUpgraddiagramsAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        System.Collections.Generic.List<Test1ReturnModel> Test1();
        System.Collections.Generic.List<Test1ReturnModel> Test1(out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<Test1ReturnModel>> Test1Async();

    }

}
// </auto-generated>
