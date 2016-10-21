using Ares.Core.Domain;

namespace Ares.Core.Domain
{

    // Administrator
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Administrator:IAggregateRoot
    {
        public int AdminId { get; set; } // AdminID (Primary key)
        public string AdminName { get; set; } // AdminName (length: 500)
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public int UserId { get; set; } // UserID
        public System.DateTime ChangedDate { get; set; } // ChangedDate
        public bool Isactive { get; set; } // Isactive

        public Administrator()
        {
            CreatedDate = System.DateTime.Now;
            ChangedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
