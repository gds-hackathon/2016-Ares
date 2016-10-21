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
    public class TransactionMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Transaction>
    {
        public TransactionMapping()
            : this("dbo")
        {
        }

        public TransactionMapping(string schema)
        {
            ToTable("Transactions", schema);
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName(@"TransactionID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").IsRequired().HasColumnType("int");
            Property(x => x.CustomerId).HasColumnName(@"CustomerID").IsRequired().HasColumnType("int");
            Property(x => x.TransactionDateTime).HasColumnName(@"TransactionDateTime").IsRequired().HasColumnType("datetime");
            Property(x => x.TotalAmount).HasColumnName(@"TotalAmount").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.DiscountAmount).HasColumnName(@"DiscountAmount").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.OrderId).HasColumnName(@"OrderID").IsOptional().HasColumnType("int");
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.ChangedDate).HasColumnName(@"ChangedDate").IsRequired().HasColumnType("datetime");
        }
    }

}
// </auto-generated>