

using System.ComponentModel;

namespace Ares.Core.Domain
{

    // Customer
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Customer : IAggregateRoot
    {
        [DisplayName("Customer Id")]
        public int CustomerId { get; set; } // CustomerID (Primary key)
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; } // CustomerName (length: 500)
        [DisplayName("IsActive")]
        public bool Isactive { get; set; } // Isactive
        [DisplayName("Discount Rating")]
        public int DiscountRating { get; set; } // DiscountRating
        public byte[] DiscountPicture { get; set; } // DiscountPicture (length: 2147483647)
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public int UserId { get; set; } // UserID
        public System.DateTime ChangedDate { get; set; } // ChangedDate
        [DisplayName("Settlement Rating")]
        public int SettlementRating { get; set; } // SettlementRating
        public System.Guid Guid { get; set; } // GUID

        public string Address { get; set; }

        public Customer()
        {
            DiscountRating = 0;
            CreatedDate = System.DateTime.Now;
            ChangedDate = System.DateTime.Now;
            SettlementRating = 100;
            Guid = System.Guid.NewGuid();
        }
    }

}
// </auto-generated>
