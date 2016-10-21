using Ares.Core.Domain;

namespace Ares.Data.Ef.Mapping
{
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
