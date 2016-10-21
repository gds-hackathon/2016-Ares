using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares.Core.Dto
{
    public class CheckTransactionByCustomerIdReturnModel
    {
        public System.Int32 TransactionID { get; set; }
        public System.Int32 EmployeeID { get; set; }
        public System.Int32 CustomerID { get; set; }
        public System.DateTime TransactionDateTime { get; set; }
        public System.Decimal TotalAmount { get; set; }
        public System.Decimal DiscountAmount { get; set; }
        public System.Int32? OrderID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ChangedDate { get; set; }
        public System.Boolean IsSuccessful { get; set; }
    }
}
