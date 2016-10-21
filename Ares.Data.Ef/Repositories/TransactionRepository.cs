using System;
using Ares.Core.Domain;
using Ares.Core.Dto;
using Ares.Core.Repositories;
using Ares.Data.Ef.UnitOfWork;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Ares.Data.Ef.Repositories
{
    public class TransactionRepository : Repository<Transaction, int>, ITransactionRepository
    {
        public TransactionRepository(IUnitOfWork unitOfWork)
          : base(unitOfWork)
        {

        }

        public int CalculateDiscount(int? employeeId, int? customerId, decimal? totalAmount, out decimal? realPay)
        {
            var employeeIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@EmployeeID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = employeeId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!employeeId.HasValue)
                employeeIdParam.Value = System.DBNull.Value;

            var customerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CustomerID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = customerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!customerId.HasValue)
                customerIdParam.Value = System.DBNull.Value;

            var totalAmountParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@TotalAmount", SqlDbType = System.Data.SqlDbType.Money, Direction = System.Data.ParameterDirection.Input, Value = totalAmount.GetValueOrDefault(), Precision = 19, Scale = 4 };
            if (!totalAmount.HasValue)
                totalAmountParam.Value = System.DBNull.Value;

            var realPayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@RealPay", SqlDbType = System.Data.SqlDbType.Money, Direction = System.Data.ParameterDirection.Output, Precision = 19, Scale = 4 };
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

           this.ActiveContext.Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[calculateDiscount] @EmployeeID, @CustomerID, @TotalAmount, @RealPay OUTPUT", employeeIdParam, customerIdParam, totalAmountParam, realPayParam, procResultParam);
            if (IsSqlParameterNull(realPayParam))
                realPay = null;
            else
                realPay = (decimal)realPayParam.Value;

            return (int)procResultParam.Value;
        }

        public CountTransactionByEmpIdReturnModel FindEmployeeTransactionSummary(int employeeId)
        {
            var employeeIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@EmployeeID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = employeeId, Precision = 10, Scale = 0 };



            var procResultData = new CountTransactionByEmpIdReturnModel();
            var cmd = this.ActiveContext.Database.Connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[countTransactionByEmpID]";
            cmd.Parameters.Add(employeeIdParam);

            try
            {
                this.ActiveContext.Database.Connection.Open();
                var reader = cmd.ExecuteReader();
                var objectContext = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)this).ObjectContext;

                procResultData.ResultSet1 = objectContext.Translate<CountTransactionByEmpIdReturnModel.ResultSetModel1>(reader).ToList();
                reader.NextResult();

                procResultData.ResultSet2 = objectContext.Translate<CountTransactionByEmpIdReturnModel.ResultSetModel2>(reader).ToList();
            }
            finally
            {
                this.ActiveContext.Database.Connection.Close();
            }
            return procResultData;
        }

    }
}
