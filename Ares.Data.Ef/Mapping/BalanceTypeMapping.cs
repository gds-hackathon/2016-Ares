using Ares.Core.Domain;

namespace Ares.Data.Ef.Mapping
{

    // BalanceType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class BalanceTypeMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BalanceType>
    {
        public BalanceTypeMapping()
            : this("dbo")
        {
        }

        public BalanceTypeMapping(string schema)
        {
            ToTable("BalanceType", schema);
            HasKey(x => x.BalanceTypeId);

            Property(x => x.BalanceTypeId).HasColumnName(@"BalanceTypeID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Balance).HasColumnName(@"Balance").IsOptional().HasColumnType("int");
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.ChangedDate).HasColumnName(@"ChangedDate").IsRequired().HasColumnType("datetime");
        }
    }

}
// </auto-generated>
