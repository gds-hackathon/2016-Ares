
namespace Ares.Core.Domain
{

    // BalanceType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class BalanceType:IAggregateRoot
    {
        public int BalanceTypeId { get; set; } // BalanceTypeID (Primary key)
        public int? Balance { get; set; } // Balance
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public System.DateTime ChangedDate { get; set; } // ChangedDate

        public BalanceType()
        {
            CreatedDate = System.DateTime.Now;
            ChangedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
