

namespace Ares.Core.Domain
{

    // RoleType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class RoleType : IAggregateRoot
    {
        public int RoleId { get; set; } // RoleID (Primary key)
        public string RoleType_ { get; set; } // RoleType (length: 100)
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public System.DateTime ChangedDate { get; set; } // ChangedDate

        public RoleType()
        {
            CreatedDate = System.DateTime.Now;
            ChangedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
