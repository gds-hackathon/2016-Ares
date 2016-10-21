using Ares.Core.Domain;

namespace Ares.Data.Ef.Mapping
{

    // RoleType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class RoleTypeMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RoleType>
    {
        public RoleTypeMapping()
            : this("dbo")
        {
        }

        public RoleTypeMapping(string schema)
        {
            ToTable("RoleType", schema);
            HasKey(x => x.RoleId);

            Property(x => x.RoleId).HasColumnName(@"RoleID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RoleType_).HasColumnName(@"RoleType").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.ChangedDate).HasColumnName(@"ChangedDate").IsRequired().HasColumnType("datetime");
        }
    }

}
// </auto-generated>
