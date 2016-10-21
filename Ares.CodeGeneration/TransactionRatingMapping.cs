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

    // TransactionRating
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class TransactionRatingMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TransactionRating>
    {
        public TransactionRatingMapping()
            : this("dbo")
        {
        }

        public TransactionRatingMapping(string schema)
        {
            ToTable("TransactionRating", schema);
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName(@"TransactionID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RateLevel).HasColumnName(@"RateLevel").IsOptional().HasColumnType("smallint");
            Property(x => x.FeedBack).HasColumnName(@"FeedBack").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.ChangedDate).HasColumnName(@"ChangedDate").IsRequired().HasColumnType("datetime");
        }
    }

}
// </auto-generated>
