using Ares.Core.Domain;

namespace Ares.Data.Ef.Mapping
{

    // UserRole
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class UserRoleMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserRole>
    {
        public UserRoleMapping()
            : this("dbo")
        {
        }

        public UserRoleMapping(string schema)
        {
            ToTable("UserRole", schema);
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RoleId).HasColumnName(@"RoleID").IsRequired().HasColumnType("int");
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.ChangedDate).HasColumnName(@"ChangedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.UserName).HasColumnName(@"UserName").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.PhoneNum).HasColumnName(@"PhoneNum").IsOptional().HasColumnType("int");
            Property(x => x.Password).HasColumnName(@"Password").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
        }
    }

}
// </auto-generated>
