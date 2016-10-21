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

    // Transactions
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Transaction
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

        public Transaction()
        {
            TransactionDateTime = System.DateTime.Now;
            CreatedDate = System.DateTime.Now;
            ChangedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
