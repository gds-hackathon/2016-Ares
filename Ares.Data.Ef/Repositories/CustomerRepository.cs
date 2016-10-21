using Ares.Core.Domain;
using Ares.Core.Repositories;
using Ares.Data.Ef.UnitOfWork;
using Ares.Core.Dto;
using System.Linq;
using System.Collections.Generic;

namespace Ares.Data.Ef.Repositories
{
   public class CustomerRepository:Repository<Customer,int>,ICustomerRepository
    {
        public CustomerRepository(IUnitOfWork unitOfWork)
          : base(unitOfWork)
        {

        }

        public System.Collections.Generic.List<GetCustomerReturnModel> GetCustomer()
        {
            int procResult;
            return GetCustomer(out procResult);
        }

        public System.Collections.Generic.List<GetCustomerReturnModel> GetCustomer(out int procResult)
        {
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = this.ActiveContext.Database.SqlQuery<GetCustomerReturnModel>("EXEC @procResult = [dbo].[getCustomer] ", procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        //public async System.Threading.Tasks.Task<System.Collections.Generic.List<GetCustomerReturnModel>> GetCustomerAsync()
        //{
        //    var procResultData = await this.ActiveContext.Database.SqlQuery<GetCustomerReturnModel>("EXEC [dbo].[getCustomer] ").ToListAsync();

        //    return procResultData;
        //}

        public System.Collections.Generic.List<SettlementForCustomerReturnModel> SettlementForCustomer(System.DateTime? startDate, System.DateTime? endDate)
        {
            int procResult;
            return SettlementForCustomer(startDate, endDate, out procResult);
        }

        public System.Collections.Generic.List<SettlementForCustomerReturnModel> SettlementForCustomer(System.DateTime? startDate, System.DateTime? endDate, out int procResult)
        {
            var startDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@StartDate", SqlDbType = System.Data.SqlDbType.Date, Direction = System.Data.ParameterDirection.Input, Value = startDate.GetValueOrDefault() };
            if (!startDate.HasValue)
                startDateParam.Value = System.DBNull.Value;

            var endDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@EndDate", SqlDbType = System.Data.SqlDbType.Date, Direction = System.Data.ParameterDirection.Input, Value = endDate.GetValueOrDefault() };
            if (!endDate.HasValue)
                endDateParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = this.ActiveContext.Database.SqlQuery<SettlementForCustomerReturnModel>("EXEC @procResult = [dbo].[settlementForCustomer] @StartDate, @EndDate", startDateParam, endDateParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }
    }
}
