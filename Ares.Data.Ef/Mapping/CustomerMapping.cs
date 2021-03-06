using Ares.Core.Domain;

namespace Ares.Data.Ef.Mapping
{

    // Customer
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class CustomerMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Customer>
    {
        public CustomerMapping(): this("dbo")
        {
        }

        public CustomerMapping(string schema)
        {
            ToTable("Customer", schema);
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName(@"CustomerID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CustomerName).HasColumnName(@"CustomerName").IsRequired().IsUnicode(false).HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Isactive).HasColumnName(@"Isactive").IsRequired().HasColumnType("bit");
            Property(x => x.DiscountRating).HasColumnName(@"DiscountRating").IsRequired().HasColumnType("int");
            Property(x => x.DiscountPicture).HasColumnName(@"DiscountPicture").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.UserId).HasColumnName(@"UserID").IsRequired().HasColumnType("int");
            Property(x => x.ChangedDate).HasColumnName(@"ChangedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.SettlementRating).HasColumnName(@"SettlementRating").IsRequired().HasColumnType("int");
            Property(x => x.Guid).HasColumnName(@"GUID").IsRequired().HasColumnType("uniqueidentifier");
            Property(x => x.Address).HasColumnName(@"Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
        }
    }

}
// </auto-generated>
