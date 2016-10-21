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

    // Customer
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class CustomerMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
            : this("dbo")
        {
        }

        public CustomerMapping(string schema)
        {
            ToTable("Customer", schema);
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName(@"CustomerID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CustomerName).HasColumnName(@"CustomerName").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Isactive).HasColumnName(@"Isactive").IsRequired().HasColumnType("bit");
            Property(x => x.DiscountRating).HasColumnName(@"DiscountRating").IsRequired().HasColumnType("int");
            Property(x => x.DiscountPicture).HasColumnName(@"DiscountPicture").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.UserId).HasColumnName(@"UserID").IsRequired().HasColumnType("int");
            Property(x => x.ChangedDate).HasColumnName(@"ChangedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.SettlementRating).HasColumnName(@"SettlementRating").IsRequired().HasColumnType("int");
        }
    }

}
// </auto-generated>
