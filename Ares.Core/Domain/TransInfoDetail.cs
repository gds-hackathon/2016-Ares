using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares.Core.Domain
{
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class TransInfoDetail : IAggregateRoot
    {
        public int TransactionId { get; set; } // TransactionID
        public int EmployeeId { get; set; } // EmployeeID
        public int CustomerId { get; set; } // CustomerID
        public System.DateTime TransactionDateTime { get; set; } // TransactionDateTime
        public decimal TotalAmount { get; set; } // TotalAmount
        public decimal DiscountAmount { get; set; } // DiscountAmount
        public int? OrderId { get; set; } // OrderID
        public bool IsSuccessful { get; set; } // IsSuccessful
        public string EmployeeName { get; set; } // EmployeeName (length: 500)
        public string CustomerName { get; set; } // CustomerName (length: 500)
        public short? RateLevel { get; set; } // RateLevel
        public string FeedBack { get; set; } // FeedBack (length: 500)
    }
}
