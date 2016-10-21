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
    }
}
