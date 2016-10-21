using System;
using System.Collections.Generic;
using Ares.Core.Domain;
using Ares.Core.Dto;

namespace Ares.Core.Repositories
{
    public interface ITransactionRepository:IRepository<Transaction,int>
    {
        CountTransactionByEmpIdReturnModel FindEmployeeTransactionSummary(int employeeId);

        int CalculateDiscount(int? employeeId, int? customerId, decimal? totalAmount, out decimal? realPay);

        System.Collections.Generic.List<CheckTransactionByCustomerIdReturnModel> CheckTransactionByCustomerId(int? customerId, out int procResult);
    }
}
