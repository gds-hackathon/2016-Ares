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

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class GdAresDbContext : System.Data.Entity.DbContext, IGdAresDbContext
    {
        public System.Data.Entity.DbSet<Administrator> Administrators { get; set; } // Administrator
        public System.Data.Entity.DbSet<BalanceType> BalanceTypes { get; set; } // BalanceType
        public System.Data.Entity.DbSet<Customer> Customers { get; set; } // Customer
        public System.Data.Entity.DbSet<Employee> Employees { get; set; } // Employee
        public System.Data.Entity.DbSet<RoleType> RoleTypes { get; set; } // RoleType
        public System.Data.Entity.DbSet<sys_DatabaseFirewallRule> sys_DatabaseFirewallRules { get; set; } // database_firewall_rules
        public System.Data.Entity.DbSet<sys_ScriptDeployment> sys_ScriptDeployments { get; set; } // script_deployments
        public System.Data.Entity.DbSet<sys_ScriptDeploymentStatus> sys_ScriptDeploymentStatus { get; set; } // script_deployment_status
        public System.Data.Entity.DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        public System.Data.Entity.DbSet<Transaction> Transactions { get; set; } // Transactions
        public System.Data.Entity.DbSet<UserRole> UserRoles { get; set; } // UserRole

        static GdAresDbContext()
        {
            System.Data.Entity.Database.SetInitializer<GdAresDbContext>(null);
        }

        public GdAresDbContext()
            : base("Name=GDAres")
        {
        }

        public GdAresDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public GdAresDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public GdAresDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public GdAresDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AdministratorMapping());
            modelBuilder.Configurations.Add(new BalanceTypeMapping());
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new EmployeeMapping());
            modelBuilder.Configurations.Add(new RoleTypeMapping());
            modelBuilder.Configurations.Add(new sys_DatabaseFirewallRuleMapping());
            modelBuilder.Configurations.Add(new sys_ScriptDeploymentMapping());
            modelBuilder.Configurations.Add(new sys_ScriptDeploymentStatusMapping());
            modelBuilder.Configurations.Add(new SysdiagramMapping());
            modelBuilder.Configurations.Add(new TransactionMapping());
            modelBuilder.Configurations.Add(new UserRoleMapping());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AdministratorMapping(schema));
            modelBuilder.Configurations.Add(new BalanceTypeMapping(schema));
            modelBuilder.Configurations.Add(new CustomerMapping(schema));
            modelBuilder.Configurations.Add(new EmployeeMapping(schema));
            modelBuilder.Configurations.Add(new RoleTypeMapping(schema));
            modelBuilder.Configurations.Add(new sys_DatabaseFirewallRuleMapping(schema));
            modelBuilder.Configurations.Add(new sys_ScriptDeploymentMapping(schema));
            modelBuilder.Configurations.Add(new sys_ScriptDeploymentStatusMapping(schema));
            modelBuilder.Configurations.Add(new SysdiagramMapping(schema));
            modelBuilder.Configurations.Add(new TransactionMapping(schema));
            modelBuilder.Configurations.Add(new UserRoleMapping(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
        public int AddNewAdmin(string adminName, string password, string userName, string phoneNum)
        {
            var adminNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@AdminName", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = adminName, Size = 500 };
            if (adminNameParam.Value == null)
                adminNameParam.Value = System.DBNull.Value;

            var passwordParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Password", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = password, Size = 500 };
            if (passwordParam.Value == null)
                passwordParam.Value = System.DBNull.Value;

            var userNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@UserName", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = userName, Size = 500 };
            if (userNameParam.Value == null)
                userNameParam.Value = System.DBNull.Value;

            var phoneNumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@PhoneNum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = phoneNum, Size = 50 };
            if (phoneNumParam.Value == null)
                phoneNumParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[addNewAdmin] @AdminName, @Password, @UserName, @PhoneNum", adminNameParam, passwordParam, userNameParam, phoneNumParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public int AddNewCustomer(string customerName, int? discountRating, byte[] discountPicture, string password, string userName, string phoneNum)
        {
            var customerNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CustomerName", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = customerName, Size = 500 };
            if (customerNameParam.Value == null)
                customerNameParam.Value = System.DBNull.Value;

            var discountRatingParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@DiscountRating", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = discountRating.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!discountRating.HasValue)
                discountRatingParam.Value = System.DBNull.Value;

            var discountPictureParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@DiscountPicture", SqlDbType = System.Data.SqlDbType.Image, Direction = System.Data.ParameterDirection.Input, Value = discountPicture, Size = 2147483647 };
            if (discountPictureParam.Value == null)
                discountPictureParam.Value = System.DBNull.Value;

            var passwordParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Password", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = password, Size = 500 };
            if (passwordParam.Value == null)
                passwordParam.Value = System.DBNull.Value;

            var userNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@UserName", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = userName, Size = 500 };
            if (userNameParam.Value == null)
                userNameParam.Value = System.DBNull.Value;

            var phoneNumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@PhoneNum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = phoneNum, Size = 50 };
            if (phoneNumParam.Value == null)
                phoneNumParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[addNewCustomer] @CustomerName, @DiscountRating, @DiscountPicture, @Password, @UserName, @PhoneNum", customerNameParam, discountRatingParam, discountPictureParam, passwordParam, userNameParam, phoneNumParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public System.Collections.Generic.List<AddNewEmployeeReturnModel> AddNewEmployee(int? employeeId, string employeeName, int? balance, string password, string userName, string phoneNum)
        {
            int procResult;
            return AddNewEmployee(employeeId, employeeName, balance, password, userName, phoneNum, out procResult);
        }

        public System.Collections.Generic.List<AddNewEmployeeReturnModel> AddNewEmployee(int? employeeId, string employeeName, int? balance, string password, string userName, string phoneNum, out int procResult)
        {
            var employeeIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@EmployeeID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = employeeId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!employeeId.HasValue)
                employeeIdParam.Value = System.DBNull.Value;

            var employeeNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@EmployeeName", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = employeeName, Size = 500 };
            if (employeeNameParam.Value == null)
                employeeNameParam.Value = System.DBNull.Value;

            var balanceParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Balance", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = balance.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!balance.HasValue)
                balanceParam.Value = System.DBNull.Value;

            var passwordParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Password", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = password, Size = 500 };
            if (passwordParam.Value == null)
                passwordParam.Value = System.DBNull.Value;

            var userNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@UserName", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = userName, Size = 500 };
            if (userNameParam.Value == null)
                userNameParam.Value = System.DBNull.Value;

            var phoneNumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@PhoneNum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = phoneNum, Size = 50 };
            if (phoneNumParam.Value == null)
                phoneNumParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<AddNewEmployeeReturnModel>("EXEC @procResult = [dbo].[addNewEmployee] @EmployeeID, @EmployeeName, @Balance, @Password, @UserName, @PhoneNum", employeeIdParam, employeeNameParam, balanceParam, passwordParam, userNameParam, phoneNumParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<AddNewEmployeeReturnModel>> AddNewEmployeeAsync(int? employeeId, string employeeName, int? balance, string password, string userName, string phoneNum)
        {
            var employeeIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@EmployeeID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = employeeId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!employeeId.HasValue)
                employeeIdParam.Value = System.DBNull.Value;

            var employeeNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@EmployeeName", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = employeeName, Size = 500 };
            if (employeeNameParam.Value == null)
                employeeNameParam.Value = System.DBNull.Value;

            var balanceParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Balance", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = balance.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!balance.HasValue)
                balanceParam.Value = System.DBNull.Value;

            var passwordParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Password", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = password, Size = 500 };
            if (passwordParam.Value == null)
                passwordParam.Value = System.DBNull.Value;

            var userNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@UserName", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = userName, Size = 500 };
            if (userNameParam.Value == null)
                userNameParam.Value = System.DBNull.Value;

            var phoneNumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@PhoneNum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = phoneNum, Size = 50 };
            if (phoneNumParam.Value == null)
                phoneNumParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<AddNewEmployeeReturnModel>("EXEC [dbo].[addNewEmployee] @EmployeeID, @EmployeeName, @Balance, @Password, @UserName, @PhoneNum", employeeIdParam, employeeNameParam, balanceParam, passwordParam, userNameParam, phoneNumParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<LoginCheckReturnModel> LoginCheck(string userName, string phoneNum, string password)
        {
            int procResult;
            return LoginCheck(userName, phoneNum, password, out procResult);
        }

        public System.Collections.Generic.List<LoginCheckReturnModel> LoginCheck(string userName, string phoneNum, string password, out int procResult)
        {
            var userNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@UserName", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = userName, Size = 500 };
            if (userNameParam.Value == null)
                userNameParam.Value = System.DBNull.Value;

            var phoneNumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@PhoneNum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = phoneNum, Size = 50 };
            if (phoneNumParam.Value == null)
                phoneNumParam.Value = System.DBNull.Value;

            var passwordParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Password", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = password, Size = 500 };
            if (passwordParam.Value == null)
                passwordParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<LoginCheckReturnModel>("EXEC @procResult = [dbo].[loginCheck] @UserName, @PhoneNum, @Password", userNameParam, phoneNumParam, passwordParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<LoginCheckReturnModel>> LoginCheckAsync(string userName, string phoneNum, string password)
        {
            var userNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@UserName", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = userName, Size = 500 };
            if (userNameParam.Value == null)
                userNameParam.Value = System.DBNull.Value;

            var phoneNumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@PhoneNum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = phoneNum, Size = 50 };
            if (phoneNumParam.Value == null)
                phoneNumParam.Value = System.DBNull.Value;

            var passwordParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Password", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = password, Size = 500 };
            if (passwordParam.Value == null)
                passwordParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<LoginCheckReturnModel>("EXEC [dbo].[loginCheck] @UserName, @PhoneNum, @Password", userNameParam, phoneNumParam, passwordParam).ToListAsync();

            return procResultData;
        }

        public int SpAlterdiagram(string diagramname, int? ownerId, int? version, byte[] definition)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var versionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@version", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = version.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!version.HasValue)
                versionParam.Value = System.DBNull.Value;

            var definitionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@definition", SqlDbType = System.Data.SqlDbType.VarBinary, Direction = System.Data.ParameterDirection.Input, Value = definition, Size = -1 };
            if (definitionParam.Value == null)
                definitionParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_alterdiagram] @diagramname, @owner_id, @version, @definition", diagramnameParam, ownerIdParam, versionParam, definitionParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public int SpCreatediagram(string diagramname, int? ownerId, int? version, byte[] definition)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var versionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@version", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = version.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!version.HasValue)
                versionParam.Value = System.DBNull.Value;

            var definitionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@definition", SqlDbType = System.Data.SqlDbType.VarBinary, Direction = System.Data.ParameterDirection.Input, Value = definition, Size = -1 };
            if (definitionParam.Value == null)
                definitionParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_creatediagram] @diagramname, @owner_id, @version, @definition", diagramnameParam, ownerIdParam, versionParam, definitionParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public int SpDropdiagram(string diagramname, int? ownerId)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_dropdiagram] @diagramname, @owner_id", diagramnameParam, ownerIdParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public System.Collections.Generic.List<SpHelpdiagramdefinitionReturnModel> SpHelpdiagramdefinition(string diagramname, int? ownerId)
        {
            int procResult;
            return SpHelpdiagramdefinition(diagramname, ownerId, out procResult);
        }

        public System.Collections.Generic.List<SpHelpdiagramdefinitionReturnModel> SpHelpdiagramdefinition(string diagramname, int? ownerId, out int procResult)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<SpHelpdiagramdefinitionReturnModel>("EXEC @procResult = [dbo].[sp_helpdiagramdefinition] @diagramname, @owner_id", diagramnameParam, ownerIdParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<SpHelpdiagramdefinitionReturnModel>> SpHelpdiagramdefinitionAsync(string diagramname, int? ownerId)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<SpHelpdiagramdefinitionReturnModel>("EXEC [dbo].[sp_helpdiagramdefinition] @diagramname, @owner_id", diagramnameParam, ownerIdParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<SpHelpdiagramsReturnModel> SpHelpdiagrams(string diagramname, int? ownerId)
        {
            int procResult;
            return SpHelpdiagrams(diagramname, ownerId, out procResult);
        }

        public System.Collections.Generic.List<SpHelpdiagramsReturnModel> SpHelpdiagrams(string diagramname, int? ownerId, out int procResult)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<SpHelpdiagramsReturnModel>("EXEC @procResult = [dbo].[sp_helpdiagrams] @diagramname, @owner_id", diagramnameParam, ownerIdParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<SpHelpdiagramsReturnModel>> SpHelpdiagramsAsync(string diagramname, int? ownerId)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<SpHelpdiagramsReturnModel>("EXEC [dbo].[sp_helpdiagrams] @diagramname, @owner_id", diagramnameParam, ownerIdParam).ToListAsync();

            return procResultData;
        }

        public int SpRenamediagram(string diagramname, int? ownerId, string newDiagramname)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var newDiagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@new_diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = newDiagramname, Size = 128 };
            if (newDiagramnameParam.Value == null)
                newDiagramnameParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_renamediagram] @diagramname, @owner_id, @new_diagramname", diagramnameParam, ownerIdParam, newDiagramnameParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public int SpUpgraddiagrams()
        {
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_upgraddiagrams] ", procResultParam);
 
            return (int) procResultParam.Value;
        }

        public System.Collections.Generic.List<Test1ReturnModel> Test1()
        {
            int procResult;
            return Test1(out procResult);
        }

        public System.Collections.Generic.List<Test1ReturnModel> Test1(out int procResult)
        {
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<Test1ReturnModel>("EXEC @procResult = [dbo].[test1] ", procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<Test1ReturnModel>> Test1Async()
        {
            var procResultData = await Database.SqlQuery<Test1ReturnModel>("EXEC [dbo].[test1] ").ToListAsync();

            return procResultData;
        }

    }
}
// </auto-generated>
