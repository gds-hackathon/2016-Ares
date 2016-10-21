namespace Ares.Core.Domain
{
    // Transactions
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Transaction : IAggregateRoot
    {
        public int TransactionId { get; set; } // TransactionID (Primary key)
        public int EmployeeId { get; set; } // EmployeeID
        public int CustomerId { get; set; } // CustomerID
        public System.DateTime TransactionDateTime { get; set; } // TransactionDateTime
        public decimal TotalAmount { get; set; } // TotalAmount
        public decimal DiscountAmount { get; set; } // DiscountAmount
        public int? OrderId { get; set; } // OrderID
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public System.DateTime ChangedDate { get; set; } // ChangedDate

        public bool IsSuccessful { get; set; }
        public Transaction()
        {
            TransactionDateTime = System.DateTime.Now;
            CreatedDate = System.DateTime.Now;
            ChangedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
