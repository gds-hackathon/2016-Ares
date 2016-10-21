using Ares.Core.Domain;

namespace Ares.Data.Ef.Mapping
{

    // Employee
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class EmployeeMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Employee>
    {
        public EmployeeMapping()
            : this("dbo")
        {
        }

        public EmployeeMapping(string schema)
        {
            ToTable("Employee", schema);
            HasKey(x => x.EmployeeId);

            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.EmployeeName).HasColumnName(@"EmployeeName").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Isactive).HasColumnName(@"Isactive").IsRequired().HasColumnType("bit");
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.BalanceTypeId).HasColumnName(@"BalanceTypeID").IsRequired().HasColumnType("int");
            Property(x => x.UserId).HasColumnName(@"UserID").IsRequired().HasColumnType("int");
            Property(x => x.ChangedDate).HasColumnName(@"ChangedDate").IsRequired().HasColumnType("datetime");
        }
    }

}
// </auto-generated>
