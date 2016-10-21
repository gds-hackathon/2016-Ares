using Ares.Core.Domain;

namespace Ares.Data.Ef.Mapping
{

    // Administrator
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class AdministratorMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Administrator>
    {
        public AdministratorMapping()
            : this("dbo")
        {
        }

        public AdministratorMapping(string schema)
        {
            ToTable("Administrator", schema);
            HasKey(x => x.AdminId);

            Property(x => x.AdminId).HasColumnName(@"AdminID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.AdminName).HasColumnName(@"AdminName").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.UserId).HasColumnName(@"UserID").IsRequired().HasColumnType("int");
            Property(x => x.ChangedDate).HasColumnName(@"ChangedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.Isactive).HasColumnName(@"Isactive").IsRequired().HasColumnType("bit");
        }
    }

}
// </auto-generated>
