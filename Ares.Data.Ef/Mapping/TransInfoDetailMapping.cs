using Ares.Core.Domain;

namespace Ares.Data.Ef.Mapping
{
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class TransInfoDetailMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TransInfoDetail>
    {
        public TransInfoDetailMapping()
            : this("dbo")
        {
        }

        public TransInfoDetailMapping(string schema)
        {
            ToTable("TransInfoDetail", schema);
            HasKey(x => new { x.TransactionId, x.EmployeeId, x.CustomerId, x.TransactionDateTime, x.TotalAmount, x.DiscountAmount, x.IsSuccessful, x.EmployeeName, x.CustomerName });

            Property(x => x.TransactionId).HasColumnName(@"TransactionID").IsRequired().HasColumnType("int");
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").IsRequired().HasColumnType("int");
            Property(x => x.CustomerId).HasColumnName(@"CustomerID").IsRequired().HasColumnType("int");
            Property(x => x.TransactionDateTime).HasColumnName(@"TransactionDateTime").IsRequired().HasColumnType("datetime");
            Property(x => x.TotalAmount).HasColumnName(@"TotalAmount").IsRequired().HasColumnType("money").HasPrecision(19, 4);
            Property(x => x.DiscountAmount).HasColumnName(@"DiscountAmount").IsRequired().HasColumnType("money").HasPrecision(19, 4);
            Property(x => x.OrderId).HasColumnName(@"OrderID").IsOptional().HasColumnType("int");
            Property(x => x.IsSuccessful).HasColumnName(@"IsSuccessful").IsRequired().HasColumnType("bit");
            Property(x => x.EmployeeName).HasColumnName(@"EmployeeName").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.CustomerName).HasColumnName(@"CustomerName").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.RateLevel).HasColumnName(@"RateLevel").IsOptional().HasColumnType("smallint");
            Property(x => x.FeedBack).HasColumnName(@"FeedBack").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
